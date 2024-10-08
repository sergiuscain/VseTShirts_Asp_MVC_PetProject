
namespace VseTShirts.Models
{
    public class ComparedProducts
    {
        public ProductViewModel[] products = new ProductViewModel[2];

        internal void RemoveAll()
        {
            products = new ProductViewModel[2];
        }
    }
}
