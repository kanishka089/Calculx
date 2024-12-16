using AccountingService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountingService
{
    public static class AccountingServiceDbContextModule
    {
        public static void AddAccountingServiceDbSet(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>();
        }
    }
}
