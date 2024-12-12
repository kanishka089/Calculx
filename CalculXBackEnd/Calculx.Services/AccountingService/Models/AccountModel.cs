using AutoMapper;
using CalculX.Base.Mapping;
using UserService.Entities;

namespace UserService.Models
{
    public class AccountModel : IMapBoth<Account>
    {
        public int? Id { get; set; } // Nullable to support optional Id
        public string AccountNumber { get; set; } = string.Empty; // Corresponds to Account.AccountNumber
        public string Name { get; set; } = string.Empty; // Corresponds to Account.Name
        public decimal Balance { get; set; } = 0.0m; // Corresponds to Account.Balance
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Corresponds to Account.CreatedAt
        public DateTime? UpdatedAt { get; set; } // Corresponds to Account.UpdatedAt

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AccountModel, Account>().ReverseMap();
        }
    }
}