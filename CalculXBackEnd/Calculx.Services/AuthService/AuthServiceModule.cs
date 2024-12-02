using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthService
{
    public static class AuthServiceModule
    {
        public static void AddAuthServices(this IServiceCollection services)
        {
            //services.AddScoped<IUserRepository, UserRepository>();
            //services.AddScoped<IUserService, UserServices>();
        }
    }
}
