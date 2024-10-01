namespace VseTShirts.Models
{
    public interface ICartsStorage
    {
        void Add(Product product, Guid userId);
        void RemoveAll(Guid userId);
        void Remove(Product product, Guid userId);
        Cart GetCart(Guid userId);
        void RemovePosition(Product product,Guid userId);
    }
}