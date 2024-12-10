using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserService.Repositories.Interfaces;
using UserService.Repositories;
using UserService.Services.Interfaces;
using UserService.Services;

namespace UserService
{
    public static class UserServiceModule
    {
        public static void AddUserServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserServices>();
        }
    }
}
