using Microsoft.Extensions.DependencyInjection;

using UserService.Repositories;
using UserService.Repositories.Interfaces;
using UserService.Services;
using UserService.Services.Interfaces;

namespace UserService;

public static class UserServiceModule
{
    public static void AddUserServices(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserServices>();
    }
}
