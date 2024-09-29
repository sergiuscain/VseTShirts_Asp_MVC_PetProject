
namespace VseTShirts.Models
{
    public class ComparedProducts
    {
        public Product[] products = new Product[2];

        internal void RemoveAll()
        {
            products = new Product[2];
        }
    }
}
