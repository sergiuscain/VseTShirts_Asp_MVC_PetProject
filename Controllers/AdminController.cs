using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{
    public class AdminController : Controller
    {
        private readonly IProductsStorage productsStorage;
        private readonly IOrdersStorage ordersStorage;
        public AdminController(IProductsStorage productsStorage, IOrdersStorage ordersStorage)
        {
            this.productsStorage = productsStorage;
            this.ordersStorage = ordersStorage;
        }
        public IActionResult Orders()
        {
            List<Order> orders = ordersStorage.GetAll();
            return View(orders);
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

        [HttpPost]
        public IActionResult UpdateStatus(int id ,OrderStatus status)
        {
            ordersStorage.UpdateStatus(id, status);
            return RedirectToAction("Orders");
        }
    }
}
