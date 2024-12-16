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

        public async Task AddAccountAsync(Account account)
        {
            await _accountingRepository.AddAsync(account);
        }

        public async Task DeleteAccountAsync(Account account)
        {
            await _accountingRepository.RemoveAsync(account);
        }
        public async Task UpdateAccountAsync(Account account)
        {
            await _accountingRepository.UpdateAsync(account);
        }
        public async Task GetDetailsByAccountNumberAsync(string accountNumber)
        {
            await _accountingRepository.GetDetailsByAccountNumberAsync(accountNumber);
        }
    }
}
