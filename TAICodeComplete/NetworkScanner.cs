using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace TAICodeComplete
{
    public class NetworkScanner
    {
        public class DiscoveredServer
        {
            public string IPAddress { get; set; }
            public int Port { get; set; }
            public string Url => $"http://{IPAddress}:{Port}";
            public string DisplayText { get; set; }

            public override string ToString()
            {
                return DisplayText ?? Url;
            }
        }

        /// <summary>
        /// Gets all local IPv4 addresses and their subnet info from active network interfaces.
        /// </summary>
        private static List<(IPAddress Address, IPAddress Mask)> GetLocalSubnets()
        {
            var subnets = new List<(IPAddress, IPAddress)>();

            foreach (var iface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (iface.OperationalStatus != OperationalStatus.Up)
                    continue;
                if (iface.NetworkInterfaceType == NetworkInterfaceType.Loopback)
                    continue;

                var props = iface.GetIPProperties();
                foreach (var unicast in props.UnicastAddresses)
                {
                    if (unicast.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        subnets.Add((unicast.Address, unicast.IPv4Mask));
                    }
                }
            }

            return subnets;
        }

        /// <summary>
        /// Generates all host IPs in a /24 (or smaller) subnet.
        /// </summary>
        private static List<IPAddress> GetSubnetHosts(IPAddress address, IPAddress mask)
        {
            var hosts = new List<IPAddress>();

            byte[] addrBytes = address.GetAddressBytes();
            byte[] maskBytes = mask.GetAddressBytes();

            byte[] networkBytes = new byte[4];
            byte[] broadcastBytes = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                networkBytes[i] = (byte)(addrBytes[i] & maskBytes[i]);
                broadcastBytes[i] = (byte)(addrBytes[i] | ~maskBytes[i]);
            }

            // Convert to uint for iteration
            uint network = (uint)(networkBytes[0] << 24 | networkBytes[1] << 16 | networkBytes[2] << 8 | networkBytes[3]);
            uint broadcast = (uint)(broadcastBytes[0] << 24 | broadcastBytes[1] << 16 | broadcastBytes[2] << 8 | broadcastBytes[3]);

            // Skip network address and broadcast address, cap at 1024 hosts to avoid huge scans
            uint maxHosts = Math.Min(broadcast - network - 1, 1024);
            for (uint i = 1; i <= maxHosts; i++)
            {
                uint hostIp = network + i;
                hosts.Add(new IPAddress(new byte[]
                {
                    (byte)(hostIp >> 24),
                    (byte)(hostIp >> 16),
                    (byte)(hostIp >> 8),
                    (byte)(hostIp)
                }));
            }

            return hosts;
        }

        /// <summary>
        /// Attempts a TCP connect to the given IP/port with a short timeout.
        /// </summary>
        private static async Task<bool> IsPortOpenAsync(IPAddress ip, int port, int timeoutMs = 500)
        {
            try
            {
                using (var client = new TcpClient())
                {
                    var connectTask = client.ConnectAsync(ip, port);
                    if (await Task.WhenAny(connectTask, Task.Delay(timeoutMs)) == connectTask)
                    {
                        // Must await to surface any connect exception (connection refused, etc.)
                        await connectTask;
                        return true;
                    }
                    // Timed out
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Tries to hit GET /v1/models on the given host to verify it's an LMStudio-compatible server.
        /// </summary>
        private static async Task<string> VerifyLMStudioAsync(string ip, int port, int timeoutMs = 2000)
        {
            try
            {
                using (var http = new System.Net.Http.HttpClient())
                {
                    http.Timeout = TimeSpan.FromMilliseconds(timeoutMs);
                    var response = await http.GetAsync($"http://{ip}:{port}/v1/models");
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch
            {
                // Not an LMStudio server or not responding to HTTP
            }
            return null;
        }

        /// <summary>
        /// Scans all local subnets for LMStudio servers on the given port.
        /// Reports progress via the optional callback.
        /// </summary>
        public static async Task<List<DiscoveredServer>> ScanForLMStudioServersAsync(
            int port = 1234,
            IProgress<string> progress = null)
        {
            var discovered = new List<DiscoveredServer>();
            var subnets = GetLocalSubnets();

            if (subnets.Count == 0)
            {
                progress?.Report("No active network interfaces found.");
                return discovered;
            }

            // Also check localhost
            progress?.Report("Checking localhost...");
            var localhostResult = await VerifyLMStudioAsync("127.0.0.1", port);
            if (localhostResult != null)
            {
                discovered.Add(new DiscoveredServer
                {
                    IPAddress = "127.0.0.1",
                    Port = port,
                    DisplayText = $"127.0.0.1:{port} (localhost)"
                });
            }

            foreach (var (address, mask) in subnets)
            {
                progress?.Report($"Scanning subnet for {address}...");

                var hosts = GetSubnetHosts(address, mask);
                progress?.Report($"  Scanning {hosts.Count} hosts on port {port}...");

                // Scan all hosts in parallel with TCP connect
                var scanTasks = hosts.Select(async ip =>
                {
                    if (await IsPortOpenAsync(ip, port))
                    {
                        return ip;
                    }
                    return null;
                }).ToList();

                var results = await Task.WhenAll(scanTasks);
                var openHosts = results.Where(r => r != null).ToList();

                progress?.Report($"  Port scan complete. {openHosts.Count} host(s) with port {port} open.");

                // Verify each open host is actually an LMStudio server
                foreach (var ip in openHosts)
                {
                    string ipStr = ip.ToString();

                    // If this is our own LAN IP and we already found localhost, just update the display
                    if (ipStr == address.ToString() && discovered.Any(d => d.IPAddress == "127.0.0.1"))
                    {
                        var existing = discovered.FirstOrDefault(d => d.IPAddress == "127.0.0.1");
                        if (existing != null)
                            existing.DisplayText = $"127.0.0.1:{port} (localhost / {ipStr})";
                        continue;
                    }

                    progress?.Report($"  Verifying {ipStr}...");
                    var verifyResult = await VerifyLMStudioAsync(ipStr, port);
                    if (verifyResult != null)
                    {
                        discovered.Add(new DiscoveredServer
                        {
                            IPAddress = ipStr,
                            Port = port,
                            DisplayText = $"{ipStr}:{port}"
                        });
                    }
                }
            }

            progress?.Report($"Scan complete. {discovered.Count} LMStudio server(s) found.");

            return discovered;
        }

        /// <summary>
        /// Scans all local subnets for SQL Server instances listening on TCP 1433 (or a custom port).
        /// </summary>
        public static async Task<List<DiscoveredServer>> ScanForSQLServersAsync(
            int port = 1433,
            IProgress<string> progress = null)
        {
            var discovered = new List<DiscoveredServer>();
            var subnets = GetLocalSubnets();

            if (subnets.Count == 0)
            {
                progress?.Report("No active network interfaces found.");
                return discovered;
            }

            // Check localhost first
            progress?.Report("Checking localhost...");
            if (await IsPortOpenAsync(System.Net.IPAddress.Parse("127.0.0.1"), port))
            {
                if (await VerifySQLServerAsync("127.0.0.1", port))
                {
                    discovered.Add(new DiscoveredServer
                    {
                        IPAddress = "127.0.0.1",
                        Port = port,
                        DisplayText = "(local)"
                    });
                }
            }

            foreach (var (address, mask) in subnets)
            {
                progress?.Report($"Scanning subnet for {address}...");

                var hosts = GetSubnetHosts(address, mask);
                progress?.Report($"  Scanning {hosts.Count} hosts on port {port}...");

                // Scan all hosts in parallel
                var scanTasks = hosts.Select(async ip =>
                {
                    if (await IsPortOpenAsync(ip, port))
                        return ip;
                    return null;
                }).ToList();

                var results = await Task.WhenAll(scanTasks);
                var openHosts = results.Where(r => r != null).ToList();

                progress?.Report($"  Port scan complete. {openHosts.Count} host(s) with port {port} open.");

                foreach (var ip in openHosts)
                {
                    string ipStr = ip.ToString();

                    // Skip if this is our own IP and we already found localhost
                    if (ipStr == address.ToString() && discovered.Any(d => d.IPAddress == "127.0.0.1"))
                    {
                        var existing = discovered.FirstOrDefault(d => d.IPAddress == "127.0.0.1");
                        if (existing != null)
                            existing.DisplayText = $"(local) / {ipStr}";
                        continue;
                    }

                    progress?.Report($"  Verifying SQL Server on {ipStr}...");
                    if (await VerifySQLServerAsync(ipStr, port))
                    {
                        discovered.Add(new DiscoveredServer
                        {
                            IPAddress = ipStr,
                            Port = port,
                            DisplayText = ipStr
                        });
                    }
                }
            }

            progress?.Report($"Scan complete. {discovered.Count} SQL Server(s) found.");
            return discovered;
        }

        /// <summary>
        /// Attempts a SQL Server prelogin handshake to verify the host is actually running SQL Server.
        /// Sends a TDS prelogin packet and checks for a valid TDS response.
        /// </summary>
        private static async Task<bool> VerifySQLServerAsync(string ip, int port, int timeoutMs = 2000)
        {
            try
            {
                using (var client = new TcpClient())
                {
                    var connectTask = client.ConnectAsync(System.Net.IPAddress.Parse(ip), port);
                    if (await Task.WhenAny(connectTask, Task.Delay(timeoutMs)) != connectTask)
                        return false;
                    await connectTask;

                    var stream = client.GetStream();
                    stream.ReadTimeout = timeoutMs;
                    stream.WriteTimeout = timeoutMs;

                    // TDS 7.0+ Prelogin packet
                    // Header: Type=0x12 (Prelogin), Status=0x01 (EOM), Length, Channel, PacketNum, Window
                    byte[] prelogin = new byte[]
                    {
                        0x12, 0x01, 0x00, 0x2F, 0x00, 0x00, 0x01, 0x00,  // TDS header (47 bytes total)
                        // Prelogin option tokens:
                        // VERSION: offset 0x15, length 6
                        0x00, 0x00, 0x15, 0x00, 0x06,
                        // ENCRYPTION: offset 0x1B, length 1
                        0x01, 0x00, 0x1B, 0x00, 0x01,
                        // INSTOPT: offset 0x1C, length 1
                        0x02, 0x00, 0x1C, 0x00, 0x01,
                        // THREADID: offset 0x1D, length 4
                        0x03, 0x00, 0x1D, 0x00, 0x04,
                        // MARS: offset 0x21, length 1
                        0x04, 0x00, 0x21, 0x00, 0x01,
                        // Terminator
                        0xFF,
                        // VERSION data: 9.0.0.0 (SQL 2005 compat)
                        0x09, 0x00, 0x00, 0x00, 0x00, 0x00,
                        // ENCRYPTION data: 0x02 = NOT_SUP
                        0x02,
                        // INSTOPT data: 0x00
                        0x00,
                        // THREADID data
                        0x00, 0x00, 0x00, 0x00,
                        // MARS data: 0x00 = off
                        0x00
                    };

                    await stream.WriteAsync(prelogin, 0, prelogin.Length);
                    await stream.FlushAsync();

                    // Read response — SQL Server should reply with a TDS prelogin response (type 0x04)
                    byte[] header = new byte[8];
                    int bytesRead = 0;
                    var readTask = Task.Run(() =>
                    {
                        try { bytesRead = stream.Read(header, 0, 8); }
                        catch { bytesRead = 0; }
                    });

                    if (await Task.WhenAny(readTask, Task.Delay(timeoutMs)) == readTask && bytesRead >= 4)
                    {
                        // TDS response type 0x04 = Tabular result (prelogin response)
                        return header[0] == 0x04;
                    }

                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}