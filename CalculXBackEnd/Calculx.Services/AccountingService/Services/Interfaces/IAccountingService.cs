using AccountingService.Entities;

namespace AccountingService.Services.Interfaces
{
    public interface IAccountingService
    {
        Task AddAccountAsync(Account account);
    }
}
