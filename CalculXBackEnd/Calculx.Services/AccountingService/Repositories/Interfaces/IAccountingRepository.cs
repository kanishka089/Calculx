using AccountingService.Entities;
using CalculX.Base.Repositories.Interfaces;

namespace AccountingService.Repositories.Interfaces
{
    public interface IAccountingRepository : IGenericRepository<Account>
    {
        Task<Account> GetAccountAsync(string email);
    }
}
