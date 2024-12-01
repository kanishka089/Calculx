namespace NotificationService.Models;

public class EmailConfiguration
{
    public required string ServerAddress { get; set; }

    public int Port { get; set; }

    public required string Username { get; set; }

    public required string Password { get; set; }
}
