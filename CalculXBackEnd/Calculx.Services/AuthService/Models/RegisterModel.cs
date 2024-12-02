using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Models
{
    public class RegisterModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string AvatarUrl { get; set; }
    }
}
