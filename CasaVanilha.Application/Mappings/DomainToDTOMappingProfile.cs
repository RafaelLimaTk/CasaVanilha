using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Domain.Entities;

namespace CasaVanilha.Application.Mappings;

public class DomainToDTOMappingProfile : Profile
{
    public DomainToDTOMappingProfile()
    {
        CreateMap<Product, ProductDto>().ReverseMap();

        CreateMap<OrderItem, OrderItemDto>()
            .ForMember(dst => dst.Product, opt => opt.MapFrom(src => src.Product))
            .ForMember(dst => dst.Quantity, opt => opt.MapFrom(src => src.Quantity))
            .ReverseMap();

        CreateMap<Order, OrderDto>()
            .ForMember(dst => dst.OrderItems, opt => opt.MapFrom(src => src.OrderItems))
            .ReverseMap();

        CreateMap<Command, CommandDto>()
            .ForMember(dst => dst.Order, opt => opt.MapFrom(src => src.Order == null ? null : src.Order))
            .ReverseMap();
    }
}
