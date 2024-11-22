using CalculX.AuthService.Models;

namespace CalculX.AuthService.Services.Interfaces
{
    public interface IAuthorizationService
    {
        void CheckAuthorization(Auth auth);
    }
}
