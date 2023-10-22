using System.ComponentModel.DataAnnotations;

namespace CasaVanilha.Application.DTOs;

public class OrderDto
{
    public Guid Id { get; set; }
    public DateTime OrderDateTime { get; set; }
    public string Status { get; set; }
    public List<OrderItemDto> OrderItems { get; set; }
    public decimal TotalPrice { get; set; }
}
