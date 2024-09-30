namespace VseTShirts.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public string Name {  get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public Cart Cart { get; set; }

        public Order ()
        {
            Id = Guid.NewGuid();
        }
    }
}
