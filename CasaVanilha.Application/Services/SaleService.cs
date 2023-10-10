using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Application.Services;

public class SaleService : Service<SaleDto, Sale>, ISaleService
{
    public SaleService(IMapper mapper, IRepository<Sale> repository) : base(mapper, repository)
    {
    }
}
