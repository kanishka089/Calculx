using ElixirBase.Repositories.Interfaces;
using UserService.Entities;

namespace UserService.Repositories.Interfaces;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User> CreateAsync(User entity);
    Task<User?> GetByIdAsync(string id);
    Task<IEnumerable<User>> GetAllAsync();
    Task<User?> UpdateAsync(User entity);
    Task<User?> DeleteAsync(string id);
}
