using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartsStorage cartsStorage;
        private readonly IProductsStorage productStorage;

        public CartController(ICartsStorage cartsStorage, IProductsStorage productStorage)
        {
            this.productStorage = productStorage;
            this.cartsStorage = cartsStorage;
        }
        public IActionResult Index()
        {
            var cart = cartsStorage.GetCart(Constants.UserId);
            return View(cart);
        }
        public IActionResult Add(int productId)
        {
            var product = productStorage.GetById(productId);
            cartsStorage.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
