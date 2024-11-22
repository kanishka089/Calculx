using CalculX.AuthService.Data.Interfaces;
using CalculX.AuthService.Models;
using CalculX.AuthService.Services.Interfaces;

namespace CalculX.AuthService.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IAuthRepository _repository;

        public AuthorizationService(IAuthRepository repository)
        {
            _repository = repository;
        }

        public void CheckAuthorization(Auth auth)
        {
            _repository.GetAuthorization(auth);
        }
    }
}
