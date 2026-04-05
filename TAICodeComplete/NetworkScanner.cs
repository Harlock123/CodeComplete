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
    }
}