using NotificationService.Entities;
using NotificationService.Enums;
using NotificationService.Repositories.Interfaces;
using NotificationService.Services.Interfaces;

namespace NotificationService.Services
{
    public class OtpService(IOtpEntryRepository otpEntryRepository, IEmailService emailService) : IOtpService
    {

        public async Task<string> GenerateAndSendOtpAsync(Guid userId, OtpType otpType)
        {
            var otp = GenerateOtp();
            var otpEntry = new OtpEntry
            {
                UserId = userId,
                Otp = otp,
                ExpiresAt = DateTime.UtcNow.AddMinutes(5),
                OtpType = otpType
            };

            await otpEntryRepository.AddAsync(otpEntry);

            //var user = await _userRepository.GetByIdAsync(userId.ToString());
            //if (user != null)
            //{
            //    var subject = "Your One-Time Password (OTP)";
            //    var body = $"Your OTP is: {otp}\n\nPlease use this OTP to complete your action. It is valid for 5 minutes.";
            //    await emailService.SendEmailAsync(user.Email, subject, body);
            //}

            return otp;
        }

        public async Task<bool> VerifyOtpAsync(Guid userId, string otp, OtpType otpType)
        {
            var otpEntry = await otpEntryRepository.GetLatestOtpAsync(userId, otpType);

            if (otpEntry == null || otpEntry.Attempts >= 3 || DateTime.UtcNow > otpEntry.ExpiresAt)
            {
                return false;
            }

            otpEntry.Attempts++;
            if (otpEntry.Otp != otp)
            {
                await otpEntryRepository.UpdateAsync(otpEntry);
                return false;
            }

            await otpEntryRepository.RemoveAsync(otpEntry);
            return true;
        }

        private string GenerateOtp()
        {
            var random = new Random();
            return random.Next(1000, 10000).ToString("D4");
        }
    }
}
