using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Application.Services.Base;
using CasaVanilha.Domain.Entities;
using CasaVanilha.Domain.Interfaces;
using CasaVanilha.Domain.Interfaces.Base;

namespace CasaVanilha.Application.Services;

public class ProductService : Service<ProductDto, Product>, IProductService
{
    private readonly IProductRepository _productRepository;
    public ProductService(IMapper mapper, IRepository<Product> repository, 
        IProductRepository productRepository) : base(mapper, repository)
    {
        _productRepository = productRepository;
    }

    public async Task UpdateStockAsync(List<OrderItem> orderItems)
    {
        foreach (var item in orderItems)
        {
            var product = await _productRepository.GetByIdAsync(item.ProductId);
            if (product != null)
            {
                product.DeductStock(item.Quantity);
                await _productRepository.UpdateAsync(product);
            }
        }
    }
}
