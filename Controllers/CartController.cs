using Microsoft.AspNetCore.Mvc;
using VseTShirts.DB;
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
        public IActionResult Add(Guid Id)
        {
            var product = productStorage.GetById(Id);
            cartsStorage.Add(product, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int Id)
        {
            var product = productStorage.GetById(Id);
            cartsStorage.Remove(product, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult RemovePosition(int Id)
        {
            var product = productStorage.GetById(Id);
            cartsStorage.RemovePosition(product, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveAll()
        {
            cartsStorage.RemoveAll(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
