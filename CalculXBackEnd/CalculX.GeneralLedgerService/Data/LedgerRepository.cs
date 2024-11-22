using CalculX.AuthService.Data.Interfaces;
using CalculX.AuthService.Models;

namespace CalculX.AuthService.Data
{
    public class LedgerRepository : ILedgerRepository
    {
        private readonly AppDbContext _context;

        public Task<Ledger> GetAuthorization(Ledger auth)
        {
            throw new NotImplementedException();
        }
    }
}
