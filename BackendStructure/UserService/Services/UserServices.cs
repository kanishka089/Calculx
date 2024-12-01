using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Entities;
using UserService.Entities.Dto;
using UserService.Repositories.Interfaces;
using UserService.Services.Interfaces;


namespace UserService.Services
{
    public class UserServices(IUserRepository _userRepository) : IUserService
    {
        public async Task<User> CreateUserAsync(UserDto dto)
        {
            var newUser = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                PhoneNumber = dto.PhoneNumber,
                Email = dto.Email,
                DOB = dto.DOB,
                Address = dto.Address,
            };

            var createdUser = await _userRepository.CreateAsync(newUser);
            return createdUser;
        }

        public async Task<User?> DeleteUserByIdAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("User ID cannot be null or empty.", nameof(id));
            }

            var user = await _userRepository.DeleteAsync(id);
            return user;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users;
        }

        public async Task<User?> GetUserByIdAsync(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("User ID cannot be null or empty.", nameof(id));
            }

            var user = await _userRepository.GetByIdAsync(id);

            if (user == null)
            {
                return null; 
            }

            return user; 
        }

        public async Task<User?> UpdateUserAsync(string id, UserDto userCreateDTO)
        {
            {
                if (string.IsNullOrEmpty(id))
                {
                    throw new ArgumentException("User ID cannot be null or empty.", nameof(id));
                }
                var user = await _userRepository.GetByIdAsync(id);
 
                user.FirstName = userCreateDTO.FirstName;
                user.LastName = userCreateDTO.LastName;
                user.PhoneNumber = userCreateDTO.PhoneNumber;
                user.Email = userCreateDTO.Email;
                user.DOB = userCreateDTO.DOB;
                user.Address = userCreateDTO.Address;

                await _userRepository.UpdateAsync(user);
                return user; 
            }
        }
    }
}
