using Microsoft.EntityFrameworkCore;
using UserService.Entities;

namespace UserService;

public static class UserServiceDbContextModule
{
    public static void AddUserServiceDbSet(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>();
    }
}
