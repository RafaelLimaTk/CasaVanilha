using CasaVanilha.Domain.Entities.Base;

namespace CasaVanilha.Domain.Interfaces.Base;

public interface IRepository<T> where T : IEntity
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid id);
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(Guid id);
    Task BeginTransaction();
    Task CommitTransaction();
    Task RollbackTransaction();
    void Attach(T entity);
}
