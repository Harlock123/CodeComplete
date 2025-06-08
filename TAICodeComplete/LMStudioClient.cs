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
        private readonly RestClient _client;

        public LMStudioClient(string baseUrl = "http://localhost:1234/v1")
        {
            _baseUrl = baseUrl;
            _client = new RestClient(_baseUrl);
           
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
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("object")]
            public string Object { get; set; }

            [JsonProperty("created")]
            public int Created { get; set; }

            [JsonProperty("owned_by")]
            public string OwnedBy { get; set; }
        }

        public async Task<List<ModelInfo>> ListModelsAsync()
        {
            var request = new RestRequest("models", Method.Get);
            request.Timeout = TimeSpan.FromSeconds(100); // Set timeout to 30 seconds

            try
            {
                var response = await _client.ExecuteAsync(request);

                if (response.IsSuccessful)
                {
                    return JsonConvert.DeserializeObject<List<ModelInfo>>(response.Content);
                }
                else
                {
                    throw new Exception($"Error listing models: {response.ErrorMessage ?? response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to list models from LMStudio: {ex.Message}");
            }
        }

        public async Task<string> GetCSharpCodeAsync(string prompt)
        {
            var request = new RestRequest("/v1/chat/completions", Method.Post);
            request.Timeout = TimeSpan.FromSeconds(100); // Set timeout to 100 seconds

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
