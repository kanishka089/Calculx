using CalculX.AuthService.Models;

namespace CalculX.AuthService.Data.Interfaces
{
    public interface IAuthRepository
    {
        Task<Auth> GetAuthorization(Auth auth);
    }
}
