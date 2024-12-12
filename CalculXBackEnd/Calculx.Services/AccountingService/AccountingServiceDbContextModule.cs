using Microsoft.EntityFrameworkCore;
using UserService.Entities;

namespace UserService
{
    public static class AccountingServiceDbContextModule
    {
        public static void AddUserServiceDbSet(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>();
        }
    }
}
