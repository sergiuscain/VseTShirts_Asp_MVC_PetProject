using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IProductsStorage productsStorage;
        private readonly IOrdersStorage ordersStorage;
        private readonly IRolesStorage rolesStorage;
        public HomeController(IProductsStorage productsStorage, IOrdersStorage ordersStorage, IRolesStorage rolesStorage)
        {
            this.productsStorage = productsStorage;
            this.ordersStorage = ordersStorage;
            this.rolesStorage = rolesStorage;
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
            var roles = rolesStorage.GetAll();
            return View(roles);
        }

        public IActionResult DeleteProduct(int ProductId)
        {
            productsStorage.Delete(ProductId);
            var products = productsStorage.GetAll();
            return View("Products", products);
        }

        public IActionResult QuantitiReduce(int ProductId) // Уменьшение количества товара на складе
        {
            productsStorage.QuantitiReduce(ProductId);
            var products = productsStorage.GetAll();
            return View("Products", products);
        }

        public IActionResult QuantityIncrease(int ProductId)  //Увеличение количества товара на складе
        {
            productsStorage.QuantityIncrease(ProductId);
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

        public IActionResult EditProduct(int id)
        {
            return View(productsStorage.GetById(id));
        }

        [HttpPost]
        public ActionResult SaveEditedProduct(ProductModel newProduct)
        {
            productsStorage.EditProduct(newProduct.Id, ProductModel.ToProduct(newProduct));
            return RedirectToAction("Products");
        }

        public IActionResult UpdateStatus(int id, OrderStatus status)
        {
            ordersStorage.UpdateStatus(id, status);
            return RedirectToAction("Orders");
        }

        public IActionResult DelOrder(int id)
        {
            ordersStorage.RemoveById(id);
            return RedirectToAction("Orders");
        }

        public IActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRole(Role role)
        {
            if (rolesStorage.GetByName(role.Name) != null)
            {
                ModelState.AddModelError("Name", "Роль уже существует!");
            }
            if (ModelState.IsValid)
            {
                rolesStorage.Add(role);
                return RedirectToAction("Roles");
            }
            return View(role);
        }

        public ActionResult RemoveRole(string name)
        {
            rolesStorage.Remove(rolesStorage.GetByName(name));
            return RedirectToAction("Roles");
        }
    }
}
