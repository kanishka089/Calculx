using System.Security.Cryptography;
using System.Text;
using UserService.Entities;
using UserService.Repositories.Interfaces;
using UserService.Services.Interfaces;

namespace UserService.Services
{
    public class UserServices : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUserAsync(User user,string password)
        {
            var passwordHash = HashPassword(password);
            user.PasswordHash = passwordHash;
            await _userRepository.AddAsync(user);
        }

        public async Task<User> LoginAsync(string email, string password)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            if (user == null || !VerifyPassword(password, user.PasswordHash))
                return null;

            return user;
        }

        public async Task<string> GeneratePasswordResetTokenAsync(string email)
        {
            var user = await _userRepository.GetUserByEmailAsync(email);
            if (user == null) return null;

            user.ResetToken = Guid.NewGuid().ToString();
            user.ResetTokenExpiry = DateTime.UtcNow.AddHours(1);

            await _userRepository.UpdateAsync(user);
            return user.ResetToken;
        }

        private static string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        private static bool VerifyPassword(string password, string storedHash) =>
            HashPassword(password) == storedHash;
    }
}
