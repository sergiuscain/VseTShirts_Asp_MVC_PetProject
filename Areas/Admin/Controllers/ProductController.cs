using Microsoft.AspNetCore.Mvc;
using VseTShirts.DB;
using VseTShirts.Models;

namespace VseTShirts.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductsStorage productsStorage;
        public ProductController(IProductsStorage productsStorage)
        {
            this.productsStorage = productsStorage;
        }

        public IActionResult Index()
        {
            var products = productsStorage.GetAll();
            return View(products);
        }

        public IActionResult Delete(Guid Id)
        {
            productsStorage.Delete(Id);
            var products = productsStorage.GetAll();
            return View(nameof(Index), products);
        }

        public IActionResult QuantitiReduce(Guid id) // Уменьшение количества товара на складе
        {
            productsStorage.QuantitiReduce(id);
            var products = productsStorage.GetAll();
            return View(nameof(Index), products);
        }

        public IActionResult QuantityIncrease(Guid id)  //Увеличение количества товара на складе
        {
            productsStorage.QuantityIncrease(id);
            var products = productsStorage.GetAll();
            return View(nameof(Index), products);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult SaveAdd(ProductModel product)
        {
            var _product = new DB.Models.Product //Надо будет это убрать!!
            {
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                Description = product.Description,
                Cost = product.Cost,
                ImagePath = product.ImagePath,
                Category = product.Category,
                Color = product.Color,
                Size = product.Size
            };
            productsStorage.Add(_product);
            var products = productsStorage.GetAll();
            return View(nameof(Index), products);
        }

        public IActionResult Edit(Guid id)
        {
            return View(productsStorage.GetById(id));
        }

        [HttpPost]
        public ActionResult SaveСhanges(DB.Models.Product newProduct)
        {
            productsStorage.EditProduct(newProduct.Id, newProduct);
            return RedirectToAction(nameof(Index));
        }
    }
}
