using AccountingService.Repositories;
using AccountingService.Repositories.Interfaces;
using AccountingService.Services;
using AccountingService.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AccountingService
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
