using VseTShirts.Models;

namespace VseTShirts
{
    public interface IOrdersStorage
    {
        void Add(Cart cart);
    }
}