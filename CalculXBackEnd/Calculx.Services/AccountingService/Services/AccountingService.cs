using AccountingService.Entities;
using AccountingService.Repositories.Interfaces;
using AccountingService.Services.Interfaces;

namespace AccountingService.Services
{
    public class AccountingServices : IAccountingService
    {
        private readonly IAccountingRepository _accountingRepository;

        public AccountingServices(IAccountingRepository accountingRepository)
        {
            _accountingRepository = accountingRepository;
        }

        public Task AddAccountAsync(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
