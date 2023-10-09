using AutoMapper;
using CasaVanilha.Application.Interfaces.Base;
using CasaVanilha.Domain.Entities.Base;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Application.Services.Base;

public class Service<TDto, TEntity> : IService<TDto, TEntity> where TEntity : EntityBase
{
    private readonly IRepository<TEntity> _repository;
    private readonly IMapper _mapper;

    public Service(IMapper mapper, IRepository<TEntity> repository)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<TEntity> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task CreateAsync(TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        await _repository.CreateAsync(entity);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task UpdateAsync(TEntity entity)
    {
        await _repository.UpdateAsync(entity);
    }

    public void Attach(TEntity entity)
    {
        _repository.Attach(entity);
    }

    public async Task BeginTransaction()
    {
        await _repository.BeginTransaction();
    }

    public async Task CommitTransaction()
    {
        await _repository.CommitTransaction();
    }

    public async Task RollbackTransaction()
    {
        await _repository.RollbackTransaction();
    }
}
