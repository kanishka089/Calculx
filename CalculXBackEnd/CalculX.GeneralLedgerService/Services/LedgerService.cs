using CalculX.AuthService.Data.Interfaces;
using CalculX.AuthService.Models;
using CalculX.AuthService.Services.Interfaces;

namespace CalculX.AuthService.Services
{
    public class LedgerService : ILedgerService
    {
        private readonly ILedgerRepository _repository;

        public LedgerService(ILedgerRepository repository)
        {
            _repository = repository;
        }

        public void CheckAuthorization(Ledger auth)
        {
            _repository.GetAuthorization(auth);
        }
    }
}
