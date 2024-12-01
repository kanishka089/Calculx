using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UserService.Enum;


namespace UserService.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [MaxLength(200)]
        public string? FirstName { get; set; }

        [MaxLength(200)]
        public string? LastName { get; set; }

        [MaxLength(15)]
        public string? PhoneNumber { get; set; }

        [MaxLength(200)]
        public string? Email { get; set; }

        public Gender Gender { get; set; }

        public DateTime DOB { get; set; }

        public required string Address { get; set; }

        public AuthProvider AuthProvider { get; set; }

        public Status Status { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; }
    }
}
