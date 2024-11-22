using CalculX.AuthService.Data.Interfaces;
using CalculX.AuthService.Models;

namespace CalculX.AuthService.Services
{
    public class AuthService
    {
        private readonly IAuthRepository _repository;

        public AuthService(IAuthRepository repository)
        {
            _repository = repository;
        }

        public async Task<Auth> AddCustomerAsync(Auth auth)
        {
            // Apply business logic
            if (string.IsNullOrWhiteSpace(auth.Role))
                throw new ArgumentException("Customer name cannot be empty");

            // Save to repository
            return await _repository.GetAuthByIdAsync(auth.Id);
        }
    }
}
