namespace CasaVanilha.Domain.Interfaces;

public interface IUnitOfWork
{
    Task SaveChangesAsync();
}
