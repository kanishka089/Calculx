using CalculX.GeneralLedgerService.Enums;
using System.ComponentModel.DataAnnotations;

namespace CalculX.GeneralLedgerService.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string Name { get; set; }
        public AccountType Type { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
