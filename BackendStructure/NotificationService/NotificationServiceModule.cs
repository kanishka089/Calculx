using Microsoft.Extensions.DependencyInjection;
using NotificationService.Repositories;
using NotificationService.Repositories.Interfaces;
using NotificationService.Services;
using NotificationService.Services.Interfaces;

namespace NotificationService;

public static class NotificationServiceModule
{
    public static void AddNotificationServices(this IServiceCollection services)
    {
        services.AddSingleton<IEmailService, EmailService>();

        services.AddScoped<IOtpService, OtpService>();
        services.AddScoped<IOtpEntryRepository, OtpEntryRepository>();
    }
}
