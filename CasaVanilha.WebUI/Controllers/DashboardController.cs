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

        public IActionResult Index(int currentPage = 1, int pageSize = 10)
        {
            var orderItemDtos = _orderItemService.GetClosedOrderByProdcut(currentPage, pageSize);
            var totalSalesValue = _orderItemService.GetTotalSalesValue();
            ViewBag.TotalSalesValue = totalSalesValue;
            ViewBag.CurrentPage = currentPage;

            return View(orderItemDtos);
        }
    }
}
