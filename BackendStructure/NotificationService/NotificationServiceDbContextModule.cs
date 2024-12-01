using Microsoft.EntityFrameworkCore;
using NotificationService.Entities;

namespace NotificationService;

public static class NotificationServiceDbContextModule
{
    public static void AddNotificationServiceDbSet(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OtpEntry>();
    }
}
