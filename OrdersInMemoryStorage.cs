using VseTShirts.Models;

namespace VseTShirts
{
    public class OrdersInMemoryStorage : IOrdersStorage
    {
        private List<Order> orders = new List<Order>();

        public void Add( Order order)
        {
            orders.Add(order);
        }
        public void Remove( Order order )
        {
            orders.Remove(order);
        }
        public List<Order> GetAll() => orders;

        public Order GetById(Guid id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            return order;
        }

        public void UpdateStatus(Guid id, OrderStatus status)
        {
            orders.FirstOrDefault(o=> o.Id == id).Status = status;
        }

        public void RemoveById(Guid id)
        {
            var removedOrder = orders.FirstOrDefault(o => o.Id == id);
            orders.Remove(removedOrder);
        }
    }
}
