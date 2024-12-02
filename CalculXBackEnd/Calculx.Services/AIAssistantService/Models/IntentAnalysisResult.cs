using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIAssistantService.Models
{
    public class IntentAnalysisResult
    {
        public string Intent { get; set; }
        public List<string> Subtasks { get; set; } = new List<string>();
    }
}
