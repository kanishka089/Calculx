using CalculX.AuthService.Models;

namespace CalculX.AuthService.Data.Interfaces
{
    public interface ILedgerRepository
    {
        Task<Ledger> GetAuthorization(Ledger auth);
    }
}
