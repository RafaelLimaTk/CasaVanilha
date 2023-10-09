using System.ComponentModel.DataAnnotations;

namespace CasaVanilha.Application.DTOs;

public class OrderDto
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "A data e hora do pedido são obrigatórias.")]
    public DateTime OrderDateTime { get; set; }

    [Required(ErrorMessage = "O status do pedido é obrigatório.")]
    [StringLength(50, ErrorMessage = "O status do pedido não pode exceder 50 caracteres.")]
    public string Status { get; set; }

    public List<OrderItemDto> OrderItems { get; set; }
}
