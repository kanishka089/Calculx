using UserService.Entities;

namespace UserService.Services.Interfaces
{
    public interface IAccountingService
    {
        Task AddUserAsync(Account account);
    }
}
