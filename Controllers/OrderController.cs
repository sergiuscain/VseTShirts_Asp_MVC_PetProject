using Microsoft.AspNetCore.Mvc;
using VseTShirts.DB;
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
            var cart = cartsStorage.GetCartByUserId(Constants.UserId);
            order.Cart = Mapping.TOCartViewModel( cart );
            ordersStorage.Add(order);
            cartsStorage.RemoveAll(Constants.UserId);
            return View(order);
        }

        public IActionResult Order(Guid id)
        {
            var order = ordersStorage.GetById(id);
            return View(order);
        }
    }
}
