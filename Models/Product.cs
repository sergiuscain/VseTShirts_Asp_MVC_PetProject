namespace VseTShirts.Models
{
    public class Product
    {
        private static int instanceCounter = 0;
        public int Id { get; set; }   //уникальный идентификатор
        public string Name { get; set; }  //название товара
        public string Description { get; set; } //описание товара
        public decimal Price { get; set; }  //цена
        public int Quantity { get; set; } //количество
        public decimal Cost { get; set; } //себестоимость
        public string ImagePath { get; set; } //патч изображения товара
        public string Category { get; set; } //категория товара
        public string Color { get; set; }
        public string Size { get; set; }


        public Product(string name, string description, decimal price, int quantity, decimal cost, string imageUrl, string category, string color, string size)
        {
            this.Id = instanceCounter;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
            this.Cost = cost;
            this.ImagePath = imageUrl;
            this.Category = category;
            instanceCounter++;
            Color = color;
            Size = size;
        }

        public override string ToString()
        {
            return $"Id:{this.Id}\t\t\t Name: {this.Name}\t\t\tDescription: {this.Description}";
        }
    }
}