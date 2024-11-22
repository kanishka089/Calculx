using CalculX.AuthService.Data.Interfaces;
using CalculX.AuthService.Models;

namespace CalculX.AuthService.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _context;
        Task IAuthRepository.AddAuthAsync(Auth customer)
        {
            throw new NotImplementedException();
        }

        Task<Auth> IAuthRepository.GetAuthByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
