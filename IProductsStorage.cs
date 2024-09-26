using VseTShirts.Models;

namespace VseTShirts
{
    public interface IProductsStorage
    {
        List<Product>? GetAll();
        Product GetById(int id);
    }
}