using UserService.Entities;
using UserService.Repositories.Interfaces;
using UserService.Services.Interfaces;

namespace UserService.Services
{
    public class AccountingServices : IAccountingService
    {
        private readonly IAccountingRepository _accountingRepository;

        public AccountingServices(IAccountingRepository accountingRepository)
        {
            _accountingRepository = accountingRepository;
        }

        Task IAccountingService.AddUserAsync(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
