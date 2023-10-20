using CasaVanilha.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CasaVanilha.WebUI.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IOrderItemService _orderItemService;

        public DashboardController(IOrderService orderService, IOrderItemService orderItemService)
        {
            _orderService = orderService;
            _orderItemService = orderItemService;
        }

        public IActionResult Index()
        {
            var orderItemDtos = _orderItemService.GetClosedOrderByProdcut();

            return View(orderItemDtos);
        }
    }
}
