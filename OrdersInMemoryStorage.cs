using VseTShirts.Models;

namespace VseTShirts
{
    public class OrdersInMemoryStorage : IOrdersStorage
    {
        private List<Cart> orders = new List<Cart>();

        public void Add(Cart cart)
        {
            orders.Add(cart);
        }
    }
}
