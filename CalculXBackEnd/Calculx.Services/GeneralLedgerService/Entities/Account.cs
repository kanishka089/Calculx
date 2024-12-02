using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneralLedgerService.Enum;

namespace GeneralLedgerService.Entities
{
    public  class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        [Required]
        public int AccountId { get; set; }

        [Required]
        [StringLength(100)] 
        public string Name { get; set; }

        [Required]
        public AccountType Type { get; set; }

        [Required]
        public bool IsActive { get; set; } = true;
    }
}
