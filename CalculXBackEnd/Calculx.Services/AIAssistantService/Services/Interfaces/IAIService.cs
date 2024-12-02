using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIAssistantService.Services.Interfaces
{
    public interface IAIService
    {
        Task<string> CallAIService(string prompt);
    }
}
