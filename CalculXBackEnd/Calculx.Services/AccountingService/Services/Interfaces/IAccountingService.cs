using AccountingService.Entities;

namespace AccountingService.Services.Interfaces
{
    public interface IAccountingService
    {
        Task AddAccountAsync(Account account);
        Task GetDetailsByAccountNumberAsync(string accountNumber);
        Task DeleteAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
    }
}