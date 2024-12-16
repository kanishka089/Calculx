using CalculX.Base.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Entities;

namespace TenantService.Repositories.Interfaces
{
    public interface ITenantRepository: IGenericRepository<Tenant>
    {
       
    }
}
