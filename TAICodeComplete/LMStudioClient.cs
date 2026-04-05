using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TAICodeComplete
{
    public class LMStudioClient
    {
        private readonly string _baseUrl;
        private readonly string _rootUrl;
        private readonly RestClient _client;

        public LMStudioClient(string baseUrl = "http://localhost:1234/v1")
        {
            _baseUrl = baseUrl;
            _client = new RestClient(_baseUrl);

            // Derive root URL (strip /v1 suffix) for native LMStudio API calls
            var uri = new Uri(baseUrl.TrimEnd('/'));
            if (uri.AbsolutePath.EndsWith("/v1", StringComparison.OrdinalIgnoreCase))
            {
                _rootUrl = uri.GetLeftPart(UriPartial.Authority);
            }
            else
            {
                _rootUrl = baseUrl.TrimEnd('/');
            }
        }

        public class ChatMessage
        {
            [JsonProperty("role")]
            public string Role { get; set; }

            [JsonProperty("content")]
            public string Content { get; set; }
        }

        public class ChatRequest
        {
            [JsonProperty("messages")]
            public List<ChatMessage> Messages { get; set; }

            [JsonProperty("model")]
            public string Model { get; set; } = "local-model"; // This can be any string for LMStudio

            [JsonProperty("temperature")]
            public double Temperature { get; set; } = 0.7;
        }

        public class ChatResponse
        {
            [JsonProperty("choices")]
            public List<Choice> Choices { get; set; }
        }

        public class Choice
        {
            [JsonProperty("message")]
            public ChatMessage Message { get; set; }
        }

        public class ModelInfo
        {
            public string Key { get; set; }
            public string DisplayName { get; set; }
            public string Type { get; set; }
            public string Publisher { get; set; }
            public string Params { get; set; }
            public bool IsLoaded { get; set; }

            public override string ToString()
            {
                string loaded = IsLoaded ? "  ** LOADED **" : "";
                string extra = !string.IsNullOrEmpty(Params) ? $" ({Params})" : "";
                return $"{DisplayName ?? Key}{extra}{loaded}";
            }
        }

        public async Task<List<ModelInfo>> ListModelsAsync()
        {
            // Use the native LMStudio API at the root URL which returns all downloaded models
            var nativeClient = new RestClient(_rootUrl);
            var request = new RestRequest("api/v0/models", Method.Get);
            request.Timeout = TimeSpan.FromSeconds(30);

            try
            {
                var response = await nativeClient.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return ParseModelsResponse(response.Content);
                }

                // Fallback: try without /api/v0 prefix (some versions use root /models)
                request = new RestRequest("models", Method.Get);
                request.Timeout = TimeSpan.FromSeconds(30);
                response = await nativeClient.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return ParseModelsResponse(response.Content);
                }

                // Last fallback: OpenAI-compatible /v1/models (only shows loaded models)
                request = new RestRequest("models", Method.Get);
                request.Timeout = TimeSpan.FromSeconds(30);
                response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return ParseModelsResponse(response.Content);
                }

                throw new Exception($"Error listing models: {response.ErrorMessage ?? response.Content}");
            }
            catch (Exception ex) when (!(ex.InnerException is null) || !ex.Message.StartsWith("Error listing"))
            {
                throw new Exception($"Failed to list models from LMStudio: {ex.Message}");
            }
        }

        private List<ModelInfo> ParseModelsResponse(string content)
        {
            var models = new List<ModelInfo>();
            var json = Newtonsoft.Json.Linq.JToken.Parse(content);

            Newtonsoft.Json.Linq.JArray itemsArray = null;

            if (json.Type == Newtonsoft.Json.Linq.JTokenType.Object)
            {
                var obj = (Newtonsoft.Json.Linq.JObject)json;

                // Native LMStudio format: { "models": [...] }
                if (obj["models"] is Newtonsoft.Json.Linq.JArray modelsArr)
                    itemsArray = modelsArr;
                // OpenAI-compatible format: { "data": [...] }
                else if (obj["data"] is Newtonsoft.Json.Linq.JArray dataArr)
                    itemsArray = dataArr;
            }
            else if (json.Type == Newtonsoft.Json.Linq.JTokenType.Array)
            {
                itemsArray = (Newtonsoft.Json.Linq.JArray)json;
            }

            if (itemsArray == null)
                return models;

            foreach (var item in itemsArray)
            {
                // Native format uses "key", OpenAI format uses "id"
                string key = item["key"]?.ToString() ?? item["id"]?.ToString();
                if (string.IsNullOrEmpty(key))
                    continue;

                // Determine if model is loaded — check multiple possible indicators
                bool isLoaded = false;
                var loadedToken = item["loaded_instances"];
                if (loadedToken != null && loadedToken.Type == Newtonsoft.Json.Linq.JTokenType.Array)
                {
                    isLoaded = loadedToken.HasValues;
                }
                // Some endpoints use a "state" or "status" field
                var stateToken = item["state"]?.ToString() ?? item["status"]?.ToString();
                if (!string.IsNullOrEmpty(stateToken) &&
                    stateToken.Equals("loaded", StringComparison.OrdinalIgnoreCase))
                {
                    isLoaded = true;
                }

                models.Add(new ModelInfo
                {
                    Key = key,
                    DisplayName = item["display_name"]?.ToString() ?? key,
                    Type = item["type"]?.ToString() ?? "llm",
                    Publisher = item["publisher"]?.ToString(),
                    Params = item["params_string"]?.ToString(),
                    IsLoaded = isLoaded
                });
            }

            return models;
        }

        /// <summary>
        /// Builds all possible identifier formats for a model that LMStudio might accept.
        /// </summary>
        private static List<string> GetModelIdentifiers(string modelKey, string publisher)
        {
            var ids = new List<string>();

            // bare key first (e.g. "claude-3.7-sonnet-reasoning-gemma3-12b")
            ids.Add(modelKey);

            // publisher/key as fallback (e.g. "reedmayhew/claude-3.7-sonnet-reasoning-gemma3-12b")
            if (!string.IsNullOrEmpty(publisher))
                ids.Add($"{publisher}/{modelKey}");

            return ids;
        }

        /// <summary>
        /// Tries a REST call. Returns status code, success flag, and content.
        /// </summary>
        private async Task<(int StatusCode, bool Success, string Content)> TryRequestAsync(
            RestClient client, string resource, Method method, object body = null, int timeoutSeconds = 30)
        {
            var request = new RestRequest(resource, method);
            request.Timeout = TimeSpan.FromSeconds(timeoutSeconds);
            if (body != null)
                request.AddJsonBody(body);
            var response = await client.ExecuteAsync(request);
            int code = (int)(response.StatusCode);
            return (code, response.IsSuccessful, response.Content ?? response.ErrorMessage ?? $"HTTP {code}");
        }

        public async Task<string> LoadModelAsync(string modelKey, string publisher = null)
        {
            var nativeClient = new RestClient(_rootUrl);
            var identifiers = GetModelIdentifiers(modelKey, publisher);
            var attempts = new List<string>();

            foreach (var modelId in identifiers)
            {
                // 1) POST /v1/models/load  { "model": "..." }  — OpenAI-compatible
                var r = await TryRequestAsync(_client, "models/load",
                    Method.Post, new { model = modelId }, 300);
                attempts.Add($"POST /v1/models/load  model={modelId}  → HTTP {r.StatusCode}");
                if (r.Success) return $"[/v1/models/load with {modelId}]\n{r.Content}";

                // 2) POST {root}/v1/models/load  { "model": "..." }  — via root client
                r = await TryRequestAsync(nativeClient, "v1/models/load",
                    Method.Post, new { model = modelId }, 300);
                attempts.Add($"POST /v1/models/load (root)  model={modelId}  → HTTP {r.StatusCode}");
                if (r.Success) return $"[root /v1/models/load with {modelId}]\n{r.Content}";
            }

            throw new Exception(
                $"Failed to load model. Tried:\n\n" +
                string.Join("\n", attempts));
        }

        public async Task<string> UnloadModelAsync(string modelKey, string publisher = null)
        {
            var nativeClient = new RestClient(_rootUrl);
            var identifiers = GetModelIdentifiers(modelKey, publisher);
            var attempts = new List<string>();

            foreach (var modelId in identifiers)
            {
                // 1) POST /v1/models/unload  { "model": "..." }  — OpenAI-compatible
                var r = await TryRequestAsync(_client, "models/unload",
                    Method.Post, new { model = modelId });
                attempts.Add($"POST /v1/models/unload  model={modelId}  → HTTP {r.StatusCode}");
                if (r.Success) return $"[/v1/models/unload with {modelId}]\n{r.Content}";

                // 2) POST {root}/v1/models/unload  { "model": "..." }  — via root client
                r = await TryRequestAsync(nativeClient, "v1/models/unload",
                    Method.Post, new { model = modelId });
                attempts.Add($"POST /v1/models/unload (root)  model={modelId}  → HTTP {r.StatusCode}");
                if (r.Success) return $"[root /v1/models/unload with {modelId}]\n{r.Content}";

                // 3) DELETE /v1/models/{id}
                r = await TryRequestAsync(_client,
                    $"models/{Uri.EscapeDataString(modelId)}", Method.Delete);
                attempts.Add($"DELETE /v1/models/{modelId}  → HTTP {r.StatusCode}");
                if (r.Success) return $"[DELETE /v1/models/{modelId}]\n{r.Content}";

                // 4) DELETE {root}/v1/models/{id}  — via root client
                r = await TryRequestAsync(nativeClient,
                    $"v1/models/{Uri.EscapeDataString(modelId)}", Method.Delete);
                attempts.Add($"DELETE /v1/models/{modelId} (root)  → HTTP {r.StatusCode}");
                if (r.Success) return $"[root DELETE /v1/models/{modelId}]\n{r.Content}";
            }

            throw new Exception(
                $"Failed to unload model. Tried:\n\n" +
                string.Join("\n", attempts));
        }

        public async Task<string> GetCSharpCodeAsync(string prompt, string model = null)
        {
            var request = new RestRequest("/v1/chat/completions", Method.Post);
            request.Timeout = TimeSpan.FromMinutes(10); // LLM inference can take several minutes

            var chatRequest = new ChatRequest
            {
                Messages = new List<ChatMessage>
            {
                new ChatMessage
                {
                    Role = "system",
                    Content = "You are a C#/Java/VB.Net programming assistant. Provide only code without explanations unless specifically asked. The code should be complete and ready to use."
                },
                new ChatMessage
                {
                    Role = "user",
                    Content = prompt
                }
            },
                Model = model ?? "local-model",
                Temperature = 0.2 // Lower temperature for more focused code generation
            };

            request.AddJsonBody(chatRequest);

            try
            {
                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    var chatResponse = JsonConvert.DeserializeObject<ChatResponse>(response.Content);
                    return chatResponse?.Choices[0]?.Message?.Content ?? string.Empty;
                }
                else
                {
                    throw new Exception($"Error: {response.ErrorMessage ?? response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get response from LMStudio: {ex.Message}");
            }
        }
    }
}
