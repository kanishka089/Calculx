using Microsoft.Extensions.DependencyInjection;
using Tenantervice.Services;
using TenantService.Repositories;
using TenantService.Repositories.Interfaces;
using TenantService.Services.Interfaces;


namespace UserService
{
    public static class TenantServiceModule
    {
        public static void AddTenantServices(this IServiceCollection services)
        {
            services.AddScoped<ITenantRepository, TenantRepository>();
            services.AddScoped<ITenantService, TenantServices>();
        }
    }
}
