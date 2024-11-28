using CalculX.AIAssistantService.Services.Interfaces;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CalculX.AIAssistantService.Services
{
    public class AIService : IAIService
    {
        private readonly HttpClient _httpClient;

        // Specify the Hugging Face model API URL
        private const string LlamaApiUrl = "https://api-inference.huggingface.co/models/meta-llama/Meta-Llama-3-8B-Instruct";

        // Your Hugging Face API key
        private const string ApiKey = "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";

        public AIService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> CallAIService(string prompt)
        {
            // Prepare the payload for the AI service
            var payload = new { inputs = prompt };
            var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

            // Add authorization header
            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");

            // Send the request to the Hugging Face API
            var response = await _httpClient.PostAsync(LlamaApiUrl, content);

            // Handle unsuccessful responses
            if (!response.IsSuccessStatusCode)
            {
                var errorContent = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Error calling AI API: {response.StatusCode}, {errorContent}");
            }

            // Return the raw AI response as a string
            return await response.Content.ReadAsStringAsync();
        }
    }
}
