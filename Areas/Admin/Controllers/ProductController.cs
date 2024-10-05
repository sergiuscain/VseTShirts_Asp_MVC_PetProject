using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Delete(int Id)
        {
            productsStorage.Delete(Id);
            var products = productsStorage.GetAll();
            return View("Index", products);
        }

        public IActionResult QuantitiReduce(int id) // Уменьшение количества товара на складе
        {
            productsStorage.QuantitiReduce(id);
            var products = productsStorage.GetAll();
            return View("Index", products);
        }

        public IActionResult QuantityIncrease(int id)  //Увеличение количества товара на складе
        {
            productsStorage.QuantityIncrease(id);
            var products = productsStorage.GetAll();
            return View("Index", products);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult SaveAdd(ProductModel product)
        {
            productsStorage.Add(ProductModel.ToProduct(product));
            var products = productsStorage.GetAll();
            return View("Index", products);
        }

        public IActionResult Edit(int id)
        {
            return View(productsStorage.GetById(id));
        }

        [HttpPost]
        public ActionResult SaveСhanges(ProductModel newProduct)
        {
            productsStorage.EditProduct(newProduct.Id, ProductModel.ToProduct(newProduct));
            return RedirectToAction("Index");
        }
    }
}
