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
        public IActionResult Add(Guid Id)
        {
            var product = productStorage.GetById(Id);
            var product1ViewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImagePath = product.ImagePath,
                Quantity = product.Quantity,
                Color = product.Color,
                Size = product.Size,
                Description = product.Description
            };
            cartsStorage.Add(product1ViewModel, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult Remove(Guid Id)
        {
            var product = productStorage.GetById(Id);
            var product1ViewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImagePath = product.ImagePath,
                Quantity = product.Quantity,
                Color = product.Color,
                Size = product.Size,
                Description = product.Description
            };
            cartsStorage.Remove(product1ViewModel, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult RemovePosition(Guid Id)
        {
            var product = productStorage.GetById(Id);
            var product1ViewModel = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImagePath = product.ImagePath,
                Quantity = product.Quantity,
                Color = product.Color,
                Size = product.Size,
                Description = product.Description
            };
            cartsStorage.RemovePosition(product1ViewModel, Constants.UserId);
            return RedirectToAction("Index");
        }
        public IActionResult RemoveAll()
        {
            cartsStorage.RemoveAll(Constants.UserId);
            return RedirectToAction("Index");
        }
    }
}
