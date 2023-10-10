using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Application.Services;

public class ProductService : Service<ProductDto, Product>, IProductService
{
    public ProductService(IMapper mapper, IRepository<Product> repository) : base(mapper, repository)
    {
    }
}
