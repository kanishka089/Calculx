using AIAssistantService.Models;
using AIAssistantService.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CalculX.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AIController : ControllerBase
    {
        private readonly IAIService _aiService;
        public AIController(IAIService aiService)
        {
            _aiService = aiService;
        }
        [HttpPost("prompt")]
        public async Task<IActionResult> GetPrompt([FromBody] PromptRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Prompt))
            {
                return BadRequest("Prompt cannot be empty.");
            }

            // Call the AI service and get the raw response
            var aiResponse = await _aiService.CallAIService(request.Prompt);

            // Return the raw AI response
            return Ok(aiResponse);
        }

        private async Task<string> ProcessPromptUsingAI(string prompt)
        {
            var aiPrompt = $@"
Identify the main intent of the following user request:
Request: {prompt}.Strictly output only the Identified Intent. Do not include any thing more.";

            var aiResponse = await _aiService.CallAIService(aiPrompt);

            try
            {
                var document = JsonDocument.Parse(aiResponse);
                if (document.RootElement.TryGetProperty("Intent", out var intent))
                {
                    return intent.GetString();
                }

                throw new InvalidOperationException("The 'Intent' field was not found in the AI response.");
            }
            catch (JsonException ex)
            {
                throw new InvalidOperationException($"Failed to parse AI response: {aiResponse}", ex);
            }
        }
    }   
    
}
