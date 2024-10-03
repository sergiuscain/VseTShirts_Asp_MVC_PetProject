using VseTShirts.Models;

namespace VseTShirts
{
    public interface IOrdersStorage
    {
        void Add( Order order);
        void Remove( Order order );
        List<Order> GetAll();
        Order GetById(int id);
        void UpdateStatus(int id, OrderStatus status);
        void RemoveById(int id);
    }
}