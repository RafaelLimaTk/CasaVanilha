using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CasaVanilha.WebUI.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public async Task<IActionResult> AddOrderItem([FromBody] OrderItemDto orderItemDto)
        {
            var orderId = await _orderService.AddOrderItemAsync(orderItemDto);
            return Ok(new { OrderId = orderId });
        }

        [HttpPost]
        public async Task<IActionResult> RemoveOrderItem(Guid orderId, Guid productId)  // Supondo que você passará os IDs como parâmetros de rota ou consulta
        {
            await _orderService.RemoveOrderItemAsync(orderId, productId);
            return Ok();
        }
    }
}
