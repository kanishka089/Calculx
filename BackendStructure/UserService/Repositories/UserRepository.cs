using KatunayakePayOffice.Repositories;
using Microsoft.EntityFrameworkCore;
using UserService.Entities;
using UserService.Repositories.Interfaces;

namespace UserService.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(DbContext context) : base(context) 
    {
        
    }

    public async Task<User> CreateAsync(User entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity), "Cannot add a null entity");

        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<User?> DeleteAsync(string id)
    {
        var user = await GetByIdAsync(id);
        if (user == null)
        {
            throw new KeyNotFoundException($"User with ID {id} not found.");
        }
        await RemoveAsync(user);

        return user;
    }

    public override async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public override async Task<User?> GetByIdAsync(string id)
    {
        if (string.IsNullOrEmpty(id))
        {
            throw new ArgumentNullException(nameof(id), "User ID cannot be null or empty.");
        }

        return await _dbSet.FindAsync(id);
    }

    public override async Task<User?> UpdateAsync(User entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException(nameof(entity), "Cannot update a null entity");
        }

        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}