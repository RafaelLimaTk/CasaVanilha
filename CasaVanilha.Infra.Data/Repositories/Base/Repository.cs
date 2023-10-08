﻿using CasaVanilha.Domain.Entities.Base;
using CasaVanilha.Domain.Interfaces.Base;
using CasaVanilha.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CasaVanilha.Infra.Data.Repositories.Base;

public class Repository<T> : IRepository<T> where T : class, IEntity
{
    private readonly ApplicationDbContext _context;
    public DbSet<T> Entities { get; }
    public Repository(ApplicationDbContext context)
    {
        _context = context;
        Entities = context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await Entities.AsNoTracking().ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await Entities.FindAsync(id);
    }

    public async Task CreateAsync(T entity)
    {
        Entities.Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        T entityToDelete = await Entities.FindAsync(id);
        Entities.Remove(entityToDelete);
        await _context.SaveChangesAsync();
    }

    public void Attach(T entity)
    {
        _context.Attach(entity);
    }

    public async Task BeginTransaction()
    {
        await _context.Database.BeginTransactionAsync();
    }

    public async Task CommitTransaction()
    {
        await _context.Database.CommitTransactionAsync();
    }

    public async Task RollbackTransaction()
    {
        await _context.Database.RollbackTransactionAsync();
    }
}
