using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICartsStorage cartsStorage;
        private readonly IOrdersStorage ordersStorage;
        public OrderController(ICartsStorage cartsStorage, IOrdersStorage ordersStorage)
        {
            this.cartsStorage = cartsStorage;
            this.ordersStorage = ordersStorage;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buy(Order order)
        {
            var cart = cartsStorage.GetCart(Constants.UserId);
            ordersStorage.Add(cart, order);
            cartsStorage.RemoveAll(Constants.UserId);
            return View(order);
        }
    }
}
