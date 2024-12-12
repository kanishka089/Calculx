using CalculX.Base.Repositories;
using Microsoft.EntityFrameworkCore;
using UserService.Entities;
using UserService.Repositories.Interfaces;

namespace UserService.Repositories
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
