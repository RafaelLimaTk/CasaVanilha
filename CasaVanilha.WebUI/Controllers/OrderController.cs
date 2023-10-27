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

        public IActionResult Index(int currentPage = 1, int pageSize = 5)
        {
            var orderDto = _orderService.GetAllOrdersWithItems(currentPage, pageSize);
            ViewBag.CurrentPage = currentPage;

            return View(orderDto);
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
        public async Task<IActionResult> CloseOrder([FromBody] OrderPrinterViewModel orderPrinterViewModel)
        {
            if (!HttpContext.Request.Cookies.ContainsKey("OrderId"))
            {
                return BadRequest("OrderId não encontrado.");
            }
            var OrderId = Guid.Parse(HttpContext.Request.Cookies["OrderId"]);

            await _orderService.CloseOrderAsync(OrderId, orderPrinterViewModel.Observation);

            return CreatedAtAction(nameof(GetOpenOrder), OrderId);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrderItem([FromBody] OrderItemViewModel OrderItemDto)
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

            var product = await _productService.GetByIdAsync(OrderItemDto.ProductId);
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
                Quantity = OrderItemDto.Quantity
            };

            await _orderService.AddOrderItemAsync(OrderId, orderItemDto);
            return CreatedAtAction(nameof(GetOpenOrder), OrderId, orderItemDto);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveOrderItem([FromBody] RemoveOrderItemViewModel removeOrderItemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orderIdResult = TryGetOrderIdFromRequest(removeOrderItemDto);

            if (!orderIdResult.Success)
            {
                return BadRequest(orderIdResult.ErrorMessage);
            }

            try
            {
                await _orderItemService.DeleteProductFromOrder(orderIdResult.OrderId, removeOrderItemDto.ProductId);
                return CreatedAtAction(nameof(GetOpenOrder), orderIdResult.OrderId);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Ocorreu um erro ao remover o item do pedido.");
            }
        }

        private (bool Success, Guid OrderId, string ErrorMessage) TryGetOrderIdFromRequest(RemoveOrderItemViewModel removeOrderItemDto)
        {
            if (removeOrderItemDto.OrderId.HasValue)
            {
                return (true, removeOrderItemDto.OrderId.Value, null);
            }

            if (HttpContext.Request.Cookies.ContainsKey("OrderId"))
            {
                return (true, Guid.Parse(HttpContext.Request.Cookies["OrderId"]), null);
            }

            return (false, Guid.Empty, "OrderId não encontrado.");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateOrderItemQuantity([FromBody] OrderItemViewModel OrderItemDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (!HttpContext.Request.Cookies.ContainsKey("OrderId"))
            {
                return BadRequest("OrderId não encontrado.");
            }
            var orderId = Guid.Parse(HttpContext.Request.Cookies["OrderId"]);

            var result = await _orderItemService.UpdateOrderItemQuantityAsync(orderId, OrderItemDto.ProductId, OrderItemDto.Quantity);
            if (!result)
            {
                return BadRequest("Erro ao atualizar a quantidade do item do pedido.");
            }

            return CreatedAtAction(nameof(GetOpenOrder), orderId);
        }

        [HttpPost]
        public IActionResult PrinterOrderItems([FromBody] OrderPrinterViewModel orderPrinterViewModel)
        {
            _orderService.PrintOrderItems(orderPrinterViewModel.OrderId, orderPrinterViewModel.Observation);

            return CreatedAtAction(nameof(GetOpenOrder), orderPrinterViewModel.OrderId);
        }
    }
}
