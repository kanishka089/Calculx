using System.Security.Cryptography;
using System.Text;
using TenantService.Entities;
using TenantService.Repositories.Interfaces;
using TenantService.Services.Interfaces;

namespace Tenantervice.Services
{
    public class TenantServices : ITenantService
    {
        private readonly ITenantRepository _repository;

        public TenantServices(ITenantRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Tenant tenant)
        {
            await _repository.AddAsync(tenant);
        }

        public async Task<Tenant> GetAsync(int id)
        {
           return await _repository.GetByIdAsync(id);
        }

    }
}
