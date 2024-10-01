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
    }
}
