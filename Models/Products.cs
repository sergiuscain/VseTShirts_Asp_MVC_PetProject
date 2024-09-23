namespace VseTShirts.Models
{
    internal class Products
    {
        public int Id { get;}   //уникальный идентификатор
        public string Name { get;}  //название товара
        public string Description { get;} //описание товара
        public decimal Price { get;}  //цена
        public int Quantity { get;} //количество
        public decimal Cost { get;} //себестоимость
        public string ImageUrl { get;} //патч изображения товара
        public string Category { get;} //категория товара
    }
}