using NotificationService.Enums;
using System.ComponentModel.DataAnnotations;

namespace NotificationService.Entities;

public class OtpEntry
{
    [Key]
    public Guid Id { get; set; } = new Guid();

    public required Guid UserId { get; set; }

    [MaxLength(6)]
    public required string Otp { get; set; }

    public DateTime Created { get; set; } = DateTime.Now;

    public required DateTime ExpiresAt { get; set; }

    [Range(0, 3)]
    public int Attempts { get; set; }

    public required OtpType OtpType { get; set; }
}

