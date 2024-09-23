using Microsoft.AspNetCore.Mvc;
using VseTShirts.Models;

namespace VseTShirts.Controllers
{

    public class ProductController : ControllerBase
    {
        private ProductStorage storage;

        public ProductController()
        {
            storage = new ProductStorage();
        }
        public string Product(int id)
        {
            var product = storage.GetById(id);
            return product is null ? $"Товар c id {id} не найден" : product.ToString();
        }
    }
}
