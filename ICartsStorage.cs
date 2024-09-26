namespace VseTShirts.Models
{
    public interface ICartsStorage
    {
        void Add(Product product, string userId);
        Cart GetCart(string userId);
    }
}