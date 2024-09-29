using VseTShirts.Models;

namespace VseTShirts
{
    public class OrdersInMemoryStorage : IOrdersStorage
    {
        private List<Cart> orders = new List<Cart>();
        public string name;
        public string address;
        public string phone;

        public void Add(Cart cart, Order order)
        {
            orders.Add(cart);
            this.name = order.Name;
            this.address = order.Address;
            this.phone = order.Phone;
        }
    }
}
