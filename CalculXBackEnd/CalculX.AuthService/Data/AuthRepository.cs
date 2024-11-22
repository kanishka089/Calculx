using CalculX.AuthService.Data.Interfaces;
using CalculX.AuthService.Models;

namespace CalculX.AuthService.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _context;

        public Task<Auth> GetAuthorization(Auth auth)
        {
            throw new NotImplementedException();
        }
    }
}
