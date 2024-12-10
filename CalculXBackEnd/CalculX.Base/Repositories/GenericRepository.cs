using CalculX.Base.Repositories.Interfaces;
using CalculX.Base.Services;
using Microsoft.EntityFrameworkCore;

namespace CalculX.Base.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly DbSet<T> _dbSet;
    protected readonly DbContext _context;

    protected GenericRepository(DbContext context)
    {
        _context = context ?? throw new ArgumentNullException(nameof(context), "DbContext cannot be null");
        _dbSet = _context.Set<T>() ?? throw new ArgumentNullException(nameof(_dbSet), "DbSet cannot be null");
    }

    [LogExecution]
    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync() ?? Enumerable.Empty<T>();
    }

    [LogExecution]
    public virtual async Task<T?> GetByIdAsync(string id)
    {
        return await _dbSet.FindAsync(id);
    }

    [LogExecution]
    public virtual async Task AddAsync(T entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity), "Cannot add a null entity");

        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    [LogExecution]
    public virtual async Task AddRangeAsync(IEnumerable<T> entities)
    {
        if (entities == null || !entities.Any())
            throw new ArgumentNullException(nameof(entities), "Cannot add an empty or null collection of entities");

        await _dbSet.AddRangeAsync(entities);
        await _context.SaveChangesAsync();
    }

    [LogExecution]
    public virtual async Task UpdateAsync(T entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity), "Cannot update a null entity");

        _dbSet.Update(entity);
        await _context.SaveChangesAsync();
    }

    [LogExecution]
    public virtual async Task RemoveAsync(T entity)
    {
        if (entity == null)
            throw new ArgumentNullException(nameof(entity), "Cannot remove a null entity");

        _dbSet.Remove(entity);
        await _context.SaveChangesAsync();
    }

    [LogExecution]
    public virtual async Task RemoveRangeAsync(IEnumerable<T> entities)
    {
        if (entities == null || !entities.Any())
            throw new ArgumentNullException(nameof(entities), "Cannot remove an empty or null collection of entities");

        _dbSet.RemoveRange(entities);
        await _context.SaveChangesAsync();
    }

    [LogExecution]
    public virtual async Task<bool> ExistsAsync(string id)
    {
        return await GetByIdAsync(id) != null;
    }
}
