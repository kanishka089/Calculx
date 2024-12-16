using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Entities;
using UserService.Entities;

namespace UserService
{
    public static class TenantServiceDbContextModule
    {
        public static void AddTenantServiceDbSet(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tenant>();
        }
    }
}
