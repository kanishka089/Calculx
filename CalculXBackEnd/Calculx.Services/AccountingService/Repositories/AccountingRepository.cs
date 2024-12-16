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

        public async Task<Account> GetDetailsByAccountNumberAsync(string accountNumber)
        {
            if (string.IsNullOrWhiteSpace(accountNumber))
                throw new ArgumentException("Account Number cannot be null or empty", nameof(accountNumber));

            var g = await _dbSet.FirstOrDefaultAsync(x => x.AccountNumber.ToLower() == accountNumber);
            return g;
        }
    }

}
