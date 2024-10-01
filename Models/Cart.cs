namespace VseTShirts.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public List<CartPosition> Position { get; set; }
        public decimal price
        {
            get
            {
                return Position.Sum(x => x.Price);
            }
        }
        public Cart(Guid userId, Guid id, List<CartPosition> positions)
        {
            UserId = userId;
            Id = id;
            Position = positions;
        }
    }
}
