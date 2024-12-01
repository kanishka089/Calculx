using System.Net.Mail;

namespace NotificationService.Services.Interfaces;

public interface IEmailService
{
    Task SendEmailAsync(string address, string subject, string body, Attachment attachment);
    Task SendEmailAsync(List<string> addresses, string subject, string body, Attachment attachment);
    Task SendEmailAsync(MailMessage message);
}
