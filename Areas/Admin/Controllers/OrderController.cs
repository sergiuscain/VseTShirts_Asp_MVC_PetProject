using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;
using VseTShirts.Areas.Admin.Models;
using VseTShirts;


namespace VseTShirts.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderController : Controller
    {
        private readonly IOrdersStorage ordersStorage;
        public OrderController(IOrdersStorage ordersStorage)
        {
            this.ordersStorage = ordersStorage;
        }
        public IActionResult Index()
        {
            List<Order> orders = ordersStorage.GetAll();
            return View(orders);
        }
        public IActionResult UpdateStatus(int id, OrderStatus status)
        {
            ordersStorage.UpdateStatus(id, status);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DelOrder(int id)
        {
            ordersStorage.RemoveById(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
