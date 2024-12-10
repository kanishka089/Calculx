using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Entities;

namespace UserService.Services.Interfaces
{
    public  interface IUserService
    {
        Task AddUserAsync(User user, string password);
        Task<User> LoginAsync(string email, string password);
        Task<string> GeneratePasswordResetTokenAsync(string email);
    }
}
