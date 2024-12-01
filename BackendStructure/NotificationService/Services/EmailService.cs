using NotificationService.Models;
using NotificationService.Services.Interfaces;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace NotificationService.Services;

public class EmailService(EmailConfiguration emailConfiguration) : IEmailService
{
    private readonly SmtpClient _smtpClient = new SmtpClient(emailConfiguration.ServerAddress);

    public async Task SendEmailAsync(string address, string subject, string body, Attachment attachment)
    {
        var addresses = new List<string> { address };
        await SendEmailAsync(addresses, subject, body, attachment);
    }

    public async Task SendEmailAsync(List<string> addresses, string subject, string body, Attachment attachment)
    {
        var message = new MailMessage();
        message.From = new MailAddress(emailConfiguration.Username);
        message.Subject = subject;
        message.Body = body;

        foreach (string address in addresses)
            message.To.Add(address);

        if (attachment is not null)
            message.Attachments.Add(attachment);

        await SendEmailAsync(message);
    }

    public async Task SendEmailAsync(MailMessage message)
    {
        message.IsBodyHtml = true;
        message.BodyEncoding = Encoding.Default;

        _smtpClient.UseDefaultCredentials = false;

        _smtpClient.Credentials = new NetworkCredential(
            emailConfiguration.Username,
            emailConfiguration.Password);

        _smtpClient.EnableSsl = true;

        await _smtpClient.SendMailAsync(message);
    }

}
