using AccountingService.Entities;
using AccountingService.Repositories.Interfaces;
using CalculX.Base.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AccountingService.Repositories
{
    public class AccountingRepository : GenericRepository<Account>, IAccountingRepository
    {
        public AccountingRepository(DbContext context) : base(context)
        {
        }

        Task<Account> IAccountingRepository.GetAccountAsync(string email)
        {
            throw new NotImplementedException();
        }
    }

}
