using CalculX.GeneralLedgerService.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalculX.GeneralLedgerService.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } // Primary Key

        [Required]
        public int AccountId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public AccountType Type { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;
    }
}
