using VseTShirts.Models;

namespace VseTShirts
{
    public class OrdersInMemoryStorage : IOrdersStorage
    {
        List<Order> orders = new List<Order>();

        public void Add( Order order)
        {
            orders.Add(order);
        }
    }
}
