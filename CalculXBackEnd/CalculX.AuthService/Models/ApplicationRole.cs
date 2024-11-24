using Microsoft.AspNetCore.Identity;

namespace CalculX.AuthService.Models
{
    public class ApplicationRole : IdentityRole
    {
        public string Description { get; set; } // Custom property
    }
}
