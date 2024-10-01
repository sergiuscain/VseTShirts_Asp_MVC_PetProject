using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductsStorage productsStorage;
        public AdminController(IProductsStorage productsStorage)
        {
            this.productsStorage = productsStorage;
        }
        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult Products()
        {
            var products = productsStorage.GetAll();
            return View(products);
        }

        public IActionResult Users()
        {
            return View();
        }

        public IActionResult Roles()
        {
            return View();
        }

        public IActionResult DeleteProduct(int ProductId)
        {
            productsStorage.Delete(ProductId);
            var products = productsStorage.GetAll();
            return View("Products", products);
        }

        public IActionResult QuantitiReduce(int ProductId)
        {
            productsStorage.QuantitiReduce(ProductId);
            var products = productsStorage.GetAll();
            return View("Products", products);
        }
        public IActionResult AddProduct()
        {
            return View();
        }
        public IActionResult CreateProduct(ProductModel product)
        {
            productsStorage.Add(ProductModel.ToProduct(product));
            var products = productsStorage.GetAll();
            return View("Products", products);
        }
    }
}
