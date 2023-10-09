using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces.Base;
using CasaVanilha.Domain.Entities;

namespace CasaVanilha.Application.Interfaces;

public interface ICommandService : IService<CommandDto, Command>
{
}
