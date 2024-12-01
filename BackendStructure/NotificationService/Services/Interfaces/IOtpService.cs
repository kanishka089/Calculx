using NotificationService.Enums;

namespace NotificationService.Services.Interfaces;

public interface IOtpService
{
    Task<string> GenerateAndSendOtpAsync(Guid userId, OtpType otpType);
    Task<bool> VerifyOtpAsync(Guid userId, string otp, OtpType otpType);
}
