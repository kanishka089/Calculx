using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(200)]
        public string FirstName { get; set; }
        [MaxLength(200)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string AvatarUrl { get; set; }
    }
}
