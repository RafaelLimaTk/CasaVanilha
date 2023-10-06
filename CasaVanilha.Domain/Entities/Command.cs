using CasaVanilha.Domain.Entities.Base;

namespace CasaVanilha.Domain.Entities;

public class Command : EntityBase
{
    private Order _order;

    private Command() { }

    public Command(Order order)
    {
        SetOrder(order);
    }

    public Order Order
    {
        get => _order;
        private set => SetOrder(value);
    }

    private void SetOrder(Order order)
    {
        _order = order ?? throw new ArgumentNullException(nameof(order));
    }
}
