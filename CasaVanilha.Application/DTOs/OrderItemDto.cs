using System.ComponentModel.DataAnnotations;

namespace CasaVanilha.Application.DTOs;

public class OrderItemDto
{
    public Guid OrderId { get; set; }
    public ProductDto Product { get; set; }

    [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser um número positivo.")]
    public int Quantity { get; set; }
}
