using CalculX.Base.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Entities;
using TenantService.Repositories.Interfaces;

namespace TenantService.Repositories
{
    public class TenantRepository : GenericRepository<Tenant>, ITenantRepository
    {
        public TenantRepository(DbContext context) : base(context)
        {
        }
        
    }

}
