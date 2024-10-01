
namespace VseTShirts.Models
{
    public  class ProductModel
    {
        private static int instanceCounter = 0;
        public int Id { get;}   //уникальный идентификатор
        public string Name { get; set; }  //название товара
        public string Description { get; set; } //описание товара
        public decimal Price { get; set; }  //цена
        public int Quantity { get; set; } //количество
        public decimal Cost { get; set; } //себестоимость
        public string ImagePath { get; set; } //патч изображения товара
        public string Category { get; set; } //категория товара
        public string Color { get; set; }
        public string Size { get; set; }

        public static Product ToProduct(ProductModel model)
        {
            return new Product(model.Name, model.Description, model.Price, model.Quantity, model.Cost, model.ImagePath, model.Category, model.Color, model.Size);
        }
    }
}