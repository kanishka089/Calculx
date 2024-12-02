using AuthService.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AuthService
{
    public static class AuthServiceDbContextModule
    {
        public static void AddAuthServiceDbSet(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>();
        }
    }
}
