using CalculX.AuthService.Models;

namespace CalculX.AuthService.Data.Interfaces
{
    public interface IAuthRepository
    {
        Task<Auth> GetAuthByIdAsync(int id);
        Task AddAuthAsync(Auth customer);
    }
}
