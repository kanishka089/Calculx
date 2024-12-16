using Microsoft.EntityFrameworkCore;
using UserService.Entities;

namespace UserService
{
    public static class UserServiceDbContextModule
    {
        public static void AddUserServiceDbSet(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<User>(builder =>
            //     {
            //    builder.HasIndex(c => c.TenantId);
            //    builder.HasQueryFilter(c => c.TenantId == tenantId);
            //});
            modelBuilder.Entity<User>();
        }
    }
}
