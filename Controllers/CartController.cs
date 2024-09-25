using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            var cart = CartsStorage.GetCart(Constants.UserId);
            return View(cart);
        }
        public IActionResult Add(int productId)
        {
            var product = ProductStorage.GetById(productId);
            CartsStorage.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
