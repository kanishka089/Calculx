using ElixirBase.Services;
using KatunayakePayOffice.Repositories;
using Microsoft.EntityFrameworkCore;
using NotificationService.Entities;
using NotificationService.Enums;
using NotificationService.Repositories.Interfaces;

namespace NotificationService.Repositories;

public class OtpEntryRepository : GenericRepository<OtpEntry>, IOtpEntryRepository
{
    public OtpEntryRepository(DbContext context) : base(context)
    {
    }

    [LogExecution]
    public async Task<OtpEntry?> GetValidOtpForUserAsync(Guid userId, OtpType otpType)
    {
        return await _dbSet.FirstOrDefaultAsync(otp => otp.UserId == userId && otp.OtpType == otpType && otp.ExpiresAt > DateTime.Now && otp.Attempts < 3);
    }

    [LogExecution]
    public async Task<OtpEntry?> GetLatestOtpAsync(Guid userId, OtpType otpType)
    {
        return await _dbSet
            .Where(e => e.UserId == userId && e.OtpType == otpType)
            .OrderByDescending(e => e.Created)
            .FirstOrDefaultAsync();
    }
}
