namespace CalculX.AIAssistantService.Services.Interfaces
{
    public interface IAIService
    {
        Task<string> CallAIService(string prompt);
    }
}
