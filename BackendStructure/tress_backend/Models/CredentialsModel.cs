using System.ComponentModel.DataAnnotations;

namespace tress_backend.Models;

public class CredentialsModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
