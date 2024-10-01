using VseTShirts.Models;

namespace VseTShirts
{
    public interface IProductsStorage
    {
        void Delete(int productId);
        List<Product>? GetAll();
        Product GetById(int id);
        void QuantitiReduce(int productId);
        void Add(Product product);
    }
}