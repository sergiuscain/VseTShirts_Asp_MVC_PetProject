

namespace VseTShirts.Models
{
    public class CartsInMemoryStorage : ICartsStorage
    {
        private List<Cart> carts = new List<Cart>();

        public Cart GetCart(string userId)
        {
            return carts.FirstOrDefault(c => c.UserId == userId);
        }

        public void Add(Product product, string userId)
        {

            var existingCart = GetCart(userId);
            if (existingCart == null)
            {
                var positions = new List<CartPosition> { new CartPosition(Guid.NewGuid(), product.Name, product, 1) };
                var cart = new Cart(userId, Guid.NewGuid(), positions);
                carts.Add(cart);
            }
            else
            {
                var existingCartItem = existingCart.Position.FirstOrDefault(p => p.Product.Id == product.Id);
                if (existingCartItem != null)
                {
                    existingCartItem.Quantity++;
                }
                else
                {
                    existingCart.Position.Add(new CartPosition(Guid.NewGuid(), product.Name, product, 1));
                }
            }
        }
    }
}
