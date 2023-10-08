using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Infra.Data.Context;
using CasaVanilha.Infra.Data.Repositories.Base;

namespace CasaVanilha.Infra.Data.Repositories;

public class CommandRepository : Repository<Command>, ICommandRepository
{
    public CommandRepository(ApplicationDbContext context) : base(context)
    {
    }
}
