using AutoMapper;
using CasaVanilha.Application.DTOs;
using CasaVanilha.Application.Interfaces;
using CasaVanilha.Domain.Entities;
using CasaVanilha.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CasaVanilha.WebUI.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IOrderItemService _orderItemService;
        private IProductService _productService;
        private IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper, 
            IProductService productService, IOrderItemService orderItemService)
        {
            _orderService = orderService;
            _mapper = mapper;
            _productService = productService;
            _orderItemService = orderItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetOrder(Guid orderId)
        {
            var order = await _orderService.GetByIdAsync(orderId);

            if (order == null)
            {
                return NotFound();

            }

            return Ok(order);
        }

        public async Task<IActionResult> GetOpenOrder()
        {
            var order = await _orderService.GetOpenOrderAsync();
            if (order == null)
                return NotFound();
            return Ok(order);
        }

        [HttpPost]
        public async Task<IActionResult> CloseOrder(Guid orderId)
        {
            await _orderService.CloseOrderAsync(orderId);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> AddOrderItem([FromBody] AddOrderItemViewModel addOrderItemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!HttpContext.Request.Cookies.ContainsKey("OrderId"))
            {
                return BadRequest("OrderId não encontrado.");
            }
            var OrderId = Guid.Parse(HttpContext.Request.Cookies["OrderId"]);

            var product = await _productService.GetByIdAsync(addOrderItemDto.ProductId);
            if (product == null)
            {
                return NotFound("Produto não encontrado.");
            }

            var orderItemDto = new OrderItemDto
            {
                OrderId = OrderId,
                Product = new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    UnitPrice = product.UnitPrice,
                    StockQuantity = product.StockQuantity
                },
                Quantity = addOrderItemDto.Quantity
            };

            await _orderService.AddOrderItemAsync(OrderId, orderItemDto);
            return CreatedAtAction(nameof(GetOpenOrder), OrderId, orderItemDto);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveOrderItem(RemoveOrderItemViewModel removeOrderItemDto)
        {
            var productId = "0dd20c22-789a-43a5-b4e9-0ec3fc40250c";

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!HttpContext.Request.Cookies.ContainsKey("OrderId"))
            {
                return BadRequest("OrderId não encontrado.");
            }

            var orderId = Guid.Parse(HttpContext.Request.Cookies["OrderId"]);

            await _orderItemService.DeleteProductFromOrder(orderId, removeOrderItemDto.ProductId);

            return CreatedAtAction(nameof(GetOpenOrder), orderId);
        }
    }
}
