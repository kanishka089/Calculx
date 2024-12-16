using CalculX.Base.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenantService.Entities;

namespace TenantService.Models
{
    public class TenantModel:IMapBoth<Tenant>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
