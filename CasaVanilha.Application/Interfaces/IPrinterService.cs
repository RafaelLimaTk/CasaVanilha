using CasaVanilha.Domain.Entities;

namespace CasaVanilha.Application.Interfaces;

public interface IPrinterService
{
    void PrintOrderItems(List<OrderItem> orderItems, string observation);
}
