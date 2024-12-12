using CalculX.Base.Repositories.Interfaces;
using UserService.Entities;

namespace UserService.Repositories.Interfaces
{
    public interface IAccountingRepository : IGenericRepository<Account>
    {
        Task<Account> GetAccountAsync(string email);
    }
}
