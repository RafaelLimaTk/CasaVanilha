using CasaVanilha.Domain.Entities;

namespace CasaVanilha.Application.Factories;

public static class OrderFactory
{
    public static Order CreateNewOrder(DateTime orderDateTime, string status)
    {
        return new Order(orderDateTime, status);
    }
}
