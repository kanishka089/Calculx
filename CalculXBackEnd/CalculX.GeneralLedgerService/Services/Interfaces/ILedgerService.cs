using CalculX.AuthService.Models;

namespace CalculX.AuthService.Services.Interfaces
{
    public interface ILedgerService
    {
        void CheckAuthorization(Ledger auth);
    }
}
