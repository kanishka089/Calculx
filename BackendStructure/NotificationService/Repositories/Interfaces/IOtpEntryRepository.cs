using ElixirBase.Repositories.Interfaces;
using NotificationService.Entities;
using NotificationService.Enums;

namespace NotificationService.Repositories.Interfaces;

public interface IOtpEntryRepository : IGenericRepository<OtpEntry>
{
    Task<OtpEntry?> GetValidOtpForUserAsync(Guid userId, OtpType otpType);

    Task<OtpEntry?> GetLatestOtpAsync(Guid userId, OtpType otpType);
}
