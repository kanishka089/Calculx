using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Entities;
using UserService.Entities.Dto;

namespace UserService.Services.Interfaces
{
    public interface IUserService
    {
        Task<User?> GetUserByIdAsync(string id); 
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> CreateUserAsync(UserDto dto);
        Task<User?> UpdateUserAsync(string id, UserDto userCreateDTO);
        Task<User?> DeleteUserByIdAsync(string id);
    }
}
