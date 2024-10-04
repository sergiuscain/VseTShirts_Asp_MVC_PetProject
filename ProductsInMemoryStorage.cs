using VseTShirts.Models;

namespace VseTShirts
{
    public class ProductsInMemoryStorage : IProductsStorage
    {
        private List<Product> products = new List<Product>()
        {
            new Product("T-Shirt1", "Белая футболка прямого кроя украшена спереди", 1800, 90, 1300, "/img/2.png", "T-Shirt", "Green", "L"),
            new Product("T-Shirt2", "Description T-Shirt", 1800, 15, 1300, "/img/2.png", "T-Shirt" , "Green", "L"),
            new Product("T-Shirt3", "Description T-Shirt", 1800, 55, 1300, "/img/2.png", "T-Shirt", "Green", "L"),
            new Product("T-Shirt4", "Description T-Shirt", 1800, 2, 1300, "/img/1.jpg", "T-Shirt", "Green", "L"),
            new Product("Sweatshirt1", "Description Sweatshirt", 2500, 120, 1800, "/img/1.jpg", "Sweatshirts", "Green", "L"),
            new Product("Jacket1", "Description Jacket", 4000, 150, 3000, "/img/1.jpg", "Jackets", "Green", "L"),
            new Product("Pants1", "Description Pants", 1500, 60, 1000, "/img/1.jpg", "Pants", "Green", "L"),
            new Product("Shoes1", "Description Shoes", 2000, 80, 1500, "/img/1.jpg", "Shoes", "Green", "L"),
            new Product("Accessories1", "Description Accessories", 500, 20, 400, "/img/1.jpg", "Accessories", "Green", "L"),
            new Product("T-Shirt1", "Description T-Shirt", 1800, 90, 1300, "/Resources/Images/tshirt1.jpg", "T-Shirt", "Green", "L"),
        };

        public void Add(Product product)
        {
            products.Add(product);
        }

        public void Delete(int productId)
        {
            products.Remove(products.FirstOrDefault(p=>p.Id==productId));
        }

        public void EditProduct(int id, Product newProduct)
        {
            products.Remove(products.FirstOrDefault(p => p.Id == id));
            newProduct.Id = id;
            products.Add(newProduct);
        }

        public List<Product>? GetAll() => products;

        public Product GetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }

        public void QuantitiReduce(int productId)
        {
            var product = products.FirstOrDefault(p => p.Id == productId);
            if (product != null && product.Quantity > 0)
                product.Quantity--;
            if (product.Quantity <= 0)
                products.Remove(product);
        }

        public void QuantityIncrease(int productId)
        {
            var product = products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
                product.Quantity++;
        }
    }
}