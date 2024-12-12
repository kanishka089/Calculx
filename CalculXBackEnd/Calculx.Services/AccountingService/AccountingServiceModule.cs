using Microsoft.Extensions.DependencyInjection;
using UserService.Repositories;
using UserService.Repositories.Interfaces;
using UserService.Services;
using UserService.Services.Interfaces;

namespace UserService
{
    public static class AccountingServiceModule
    {
        public static void AddAccountingServices(this IServiceCollection services)
        {
            services.AddScoped<IAccountingRepository, AccountingRepository>();
            services.AddScoped<IAccountingService, AccountingServices>();
        }
    }
}
