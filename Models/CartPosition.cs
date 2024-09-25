namespace VseTShirts.Models
{
    public class CartPosition
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Product? Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price
        {
            get
            {
                return Product.Price* Quantity;
            }
        }
        public CartPosition(Guid id, string name, Product? product, int quantity)
        {
            Id = id;
            Name = name;
            Product = product;
            Quantity = quantity;
        }
    }
}
