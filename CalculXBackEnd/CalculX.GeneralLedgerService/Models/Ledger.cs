using System.ComponentModel.DataAnnotations;

namespace CalculX.AuthService.Models
{
    public class Ledger
    {
        [Key]
        public int Id { get; set; } // Primary Key
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public DateTime? DateUpdated { get; set; }
    }
}
