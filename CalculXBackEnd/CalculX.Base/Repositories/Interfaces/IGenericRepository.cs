namespace CalculX.Base.Repositories.Interfaces;

public interface IGenericRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();

    Task<T?> GetByIdAsync(string id);

    Task AddAsync(T entity);

    Task AddRangeAsync(IEnumerable<T> entities);

    Task UpdateAsync(T entity);

    Task RemoveAsync(T entity);

    Task RemoveRangeAsync(IEnumerable<T> entities);

    Task<bool> ExistsAsync(string id);
}
