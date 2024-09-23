namespace VseTShirts.Models
{
    internal class Products
    {
        public int Id { get; set; }   //уникальный идентификатор
        public string Name { get; set; }  //название товара
        public string Description { get; set; } //описание товара
        public decimal Price { get; set; }  //цена
        public int Quantity { get; set; } //количество
        public decimal Cost { get; set; } //себестоимость
        public string ImageUrl { get; set; } //патч изображения товара
        public string Category { get; set; } //категория товара
    }
}