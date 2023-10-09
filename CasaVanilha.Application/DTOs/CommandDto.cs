using System.ComponentModel.DataAnnotations;

namespace CasaVanilha.Application.DTOs;

public class CommandDto
{
    public Guid Id { get; set; }

    [Required(ErrorMessage = "O ID do pedido é obrigatório.")]
    public Guid OrderId { get; set; }
    public OrderDto Order { get; set; }
}
