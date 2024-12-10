using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Entities;

namespace UserService
{
    public static class UserServiceDbContextModule
    {
        public static void AddUserServiceDbSet(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
        }
    }
}
