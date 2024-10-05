namespace VseTShirts.Models
{
    public class CartsInMemoryStorage : ICartsStorage
    {
        private List<Cart> carts = new List<Cart>();

        public Cart GetCart(Guid userId)
        {
            return carts.FirstOrDefault(c => c.UserId == userId);
        }

        public void Add(Product product, Guid userId)
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
                var existingCartItem = existingCart?.Position?.FirstOrDefault(p => p.Product.Id == product.Id);
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

        public void Remove(Product product, Guid userId)
        {
            var cart = GetCart(userId);
            var cartItem = cart.Position.FirstOrDefault(p => p.Product.Id == product.Id);
            cartItem.Quantity--;
            if (cartItem.Quantity <= 0)
            {
                cart.Position.Remove(cartItem);
            }
            if (cart.Position.Count <= 0)
            {
                carts.Remove(cart);
            }
        }
        public void RemovePosition(Product product, Guid usertId)
        {
            var cart = GetCart(usertId);
            var removedCartPosition = cart.Position.FirstOrDefault(p => p.Product.Id == product.Id);
            cart.Position.Remove(removedCartPosition);
            if (cart.Position.Count <= 0)
            {
                carts.Remove(cart);
            }
        }

        public void RemoveAll(Guid userId)
        {
            carts.Remove(carts.FirstOrDefault(p => p.UserId == userId));
        }
    }
}
