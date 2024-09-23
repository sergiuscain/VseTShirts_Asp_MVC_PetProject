using VseTShirts.Models;

namespace VseTShirts
{
    public class ProductStorage
    {
        private static List<Product> products = new List<Product>()
        {
            new Product("T-Shirt1", "Description T-Shirt", 1800, 90, 1300, "/Resources/Images/tshirt1.jpg", "T-Shirt"),
            new Product("T-Shirt2", "Description T-Shirt", 1800, 15, 1300, "/images/tshirt2.jpg", "T-Shirt"),
            new Product("T-Shirt3", "Description T-Shirt", 1800, 55, 1300, "/images/tshirt3.jpg", "T-Shirt"),
            new Product("T-Shirt4", "Description T-Shirt", 1800, 2, 1300, "/images/tshirt4.jpg", "T-Shirt"),
            new Product("Sweatshirt1", "Description Sweatshirt", 2500, 120, 1800, "/images/sweatshirt.jpg", "Sweatshirts"),
            new Product("Jacket1", "Description Jacket", 4000, 150, 3000, "/images/jacket.jpg", "Jackets"),
            new Product("Pants1", "Description Pants", 1500, 60, 1000, "/images/pants.jpg", "Pants"),
            new Product("Shoes1", "Description Shoes", 2000, 80, 1500, "/images/shoes.jpg", "Shoes"),
            new Product("Accessories1", "Description Accessories", 500, 20, 400, "/images/accessories.jpg", "Accessories"),
            new Product("T-Shirt1", "Description T-Shirt", 1800, 90, 1300, "/Resources/Images/tshirt1.jpg", "T-Shirt"),
            new Product("T-Shirt2", "Description T-Shirt", 1800, 15, 1300, "/images/tshirt2.jpg", "T-Shirt"),
            new Product("T-Shirt3", "Description T-Shirt", 1800, 55, 1300, "/images/tshirt3.jpg", "T-Shirt"),
            new Product("T-Shirt4", "Description T-Shirt", 1800, 2, 1300, "/images/tshirt4.jpg", "T-Shirt"),
            new Product("Sweatshirt1", "Description Sweatshirt", 2500, 120, 1800, "/images/sweatshirt.jpg", "Sweatshirts"),
            new Product("Jacket1", "Description Jacket", 4000, 150, 3000, "/images/jacket.jpg", "Jackets"),
            new Product("Pants1", "Description Pants", 1500, 60, 1000, "/images/pants.jpg", "Pants"),
            new Product("Shoes1", "Description Shoes", 2000, 80, 1500, "/images/shoes.jpg", "Shoes"),
            new Product("Accessories1", "Description Accessories", 500, 20, 400, "/images/accessories.jpg", "Accessories"),
            new Product("T-Shirt1", "Description T-Shirt", 1800, 90, 1300, "/Resources/Images/tshirt1.jpg", "T-Shirt"),
            new Product("T-Shirt2", "Description T-Shirt", 1800, 15, 1300, "/images/tshirt2.jpg", "T-Shirt"),
            new Product("T-Shirt3", "Description T-Shirt", 1800, 55, 1300, "/images/tshirt3.jpg", "T-Shirt"),
            new Product("T-Shirt4", "Description T-Shirt", 1800, 2, 1300, "/images/tshirt4.jpg", "T-Shirt"),
            new Product("Sweatshirt1", "Description Sweatshirt", 2500, 120, 1800, "/images/sweatshirt.jpg", "Sweatshirts"),
            new Product("Jacket1", "Description Jacket", 4000, 150, 3000, "/images/jacket.jpg", "Jackets"),
            new Product("Pants1", "Description Pants", 1500, 60, 1000, "/images/pants.jpg", "Pants"),
            new Product("Shoes1", "Description Shoes", 2000, 80, 1500, "/images/shoes.jpg", "Shoes"),
            new Product("Accessories1", "Description Accessories", 500, 20, 400, "/images/accessories.jpg", "Accessories")

        };

        public ProductStorage()
        {
            
        }

        internal List<Product>? GetAll() => products;

        internal Product GetById(int id)
        {
            return products.FirstOrDefault(product => product.Id == id);
        }
    }
}