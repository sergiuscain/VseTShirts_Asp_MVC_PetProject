namespace VseTShirts.Models
{
    public interface ICartsStorage
    {
        void Add(Product product, string userId);
        Cart GetCart(string userId);
        void Remove(Product product,string userId);
        void RemoveAll(Product product, string userId);
    }
}