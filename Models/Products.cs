namespace VseTShirts.Models
{
    internal class Products
    {
        int instanceCounter = 0;
        public int Id { get;}   //уникальный идентификатор
        public string Name { get;}  //название товара
        public string Description { get;} //описание товара
        public decimal Price { get;}  //цена
        public int Quantity { get;} //количество
        public decimal Cost { get;} //себестоимость
        public string ImageUrl { get;} //патч изображения товара
        public string Category { get;} //категория товара

        public Products(string name, string description, decimal price, int quantity, decimal cost, string imageUrl, string category)
        {
            this.Id = instanceCounter;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
            this.Cost = cost;
            this.ImageUrl = imageUrl;
            this.Category = category;
            instanceCounter++;
        }
    }
}