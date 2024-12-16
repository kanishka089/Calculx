using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Entities;

namespace TenantService.Services.Interfaces
{
    public  interface ITenantService
    {
        Task AddAsync(Tenant tenant);
        Task<Tenant> GetAsync(int id);
    }
}
