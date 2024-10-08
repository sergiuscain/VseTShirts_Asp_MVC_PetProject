namespace VseTShirts.Models
{
    public interface ICartsStorage
    {
        void Add(ProductViewModel product, Guid userId);
        void RemoveAll(Guid userId);
        void Remove(ProductViewModel product, Guid userId);
        Cart GetCart(Guid userId);
        void RemovePosition(ProductViewModel product,Guid userId);
    }
}