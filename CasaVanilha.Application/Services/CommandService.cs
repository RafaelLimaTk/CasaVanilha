using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Application.Services;

public class CommandService : Service<CommandDto, Command>, ICommandService
{
    public CommandService(IMapper mapper, IRepository<Command> repository) : base(mapper, repository)
    {
    }
}
