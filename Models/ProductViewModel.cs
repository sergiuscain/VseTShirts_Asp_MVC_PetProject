using VseTShirts.DB.Models;

namespace VseTShirts.Models
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }   //уникальный идентификатор
        public string Name { get; set; }  //название товара
        public string Description { get; set; } //описание товара
        public decimal Price { get; set; }  //цена
        public int Quantity { get; set; } //количество
        public decimal Cost { get; set; } //себестоимость
        public string ImagePath { get; set; } //патч изображения товара
        public string Category { get; set; } //категория товара
        public string Color { get; set; }
        public string Size { get; set; }


        public override string ToString()
        {
            return $"Id:{this.Id}\t\t\t Name: {this.Name}\t\t\tDescription: {this.Description}";
        }

        public static List<ProductViewModel> ToProductsViewModel(List<Product> list)
        {
            var products = new List<ProductViewModel>();
            foreach (var item in list)
            {
                var productViewModel = new ProductViewModel();
                productViewModel.Id = item.Id;
                productViewModel.Name = item.Name;
                productViewModel.Description = item.Description;
                productViewModel.Price = item.Price;
                productViewModel.Quantity = item.Quantity;
                productViewModel.Cost = item.Cost;
                productViewModel.ImagePath = item.ImagePath;
                productViewModel.Category = item.Category;
                productViewModel.Color = item.Color;
                productViewModel.Size = item.Size;
                products.Add(productViewModel);
            }
            return products;
        }
        public static ProductViewModel ToProductViewModel(Product product)
        {
            return new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Quantity = product.Quantity,
                Cost = product.Cost,
                ImagePath = product.ImagePath,
                Category = product.Category,
                Color = product.Color,
                Size = product.Size,
            };
        }


        public static List<Product> ToProducts(List<ProductViewModel> list)
        {
            var products = new List<Product>();
            foreach (var item in list)
            {
                var product = new Product();
                product.Id = item.Id;
                product.Name = item.Name;
                product.Description = item.Description;
                product.Price = item.Price;
                product.Quantity = item.Quantity;
                product.Cost = item.Cost;
                product.ImagePath = item.ImagePath;
                product.Category = item.Category;
                product.Color = item.Color;
                product.Size = item.Size;
                products.Add(product);
            }
            return products;
        }
        public static Product ToProduct(ProductViewModel productVM)
        {
            return new Product
            {
                Id = productVM.Id,
                Name = productVM.Name,
                Description = productVM.Description,
                Price = productVM.Price,
                Quantity = productVM.Quantity,
                Cost = productVM.Cost,
                ImagePath = productVM.ImagePath,
                Category = productVM.Category,
                Color = productVM.Color,
                Size = productVM.Size,
            };
        }
    }
}