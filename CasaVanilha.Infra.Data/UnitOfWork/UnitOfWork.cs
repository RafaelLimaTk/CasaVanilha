using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Infra.Data.Context;

namespace CasaVanilha.Infra.Data.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
