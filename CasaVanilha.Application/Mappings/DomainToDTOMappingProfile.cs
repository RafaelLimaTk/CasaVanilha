using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Domain.Entities;

namespace CasaVanilha.Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id == Guid.Empty ? Guid.NewGuid() : x.Id))
            .ReverseMap();

        CreateMap<OrderItem, OrderItemDto>()
            .ForMember(dst => dst.Product, opt => opt.MapFrom(src => src.Product))
            .ForMember(dst => dst.Quantity, opt => opt.MapFrom(src => src.Quantity))
            .ReverseMap();

        CreateMap<Order, OrderDto>()
            .ForMember(dst => dst.TotalPrice, opt => opt.MapFrom(src => src.OrderItems.Sum(item => item.Product.UnitPrice * item.Quantity)))
            .ReverseMap();

        CreateMap<Command, CommandDto>()
            .ForMember(dst => dst.Order, opt => opt.MapFrom(src => src.Order == null ? null : src.Order))
            .ReverseMap();
    }
}
