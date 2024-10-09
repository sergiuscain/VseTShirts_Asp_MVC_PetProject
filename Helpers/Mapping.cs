using VseTShirts.DB.Models;
using VseTShirts.Models;

namespace VseTShirts;

public class Mapping
{
    public static CartViewModel TOCartViewModel(Cart cartDB)
    {
        if (cartDB == null)
            return null;
        CartViewModel newCart = new CartViewModel();
        newCart.Id = cartDB.Id;
        newCart.UserId = cartDB.UserId;
        List<CartPositionViewModel> positions = new List<CartPositionViewModel>();
        foreach (var position in cartDB.Positions)
        {
            positions.Add(new CartPositionViewModel
            {
                Id = position.Id,
                Name = position.Name,
                Product = ToProductViewModel(position.Product),
                Quantity = position.Quantity,
            });
        }
        newCart.Positions = positions;
        return newCart;
    }

    public static List<ProductViewModel> ToProductsViewModel(List<Product> list)
    {
        var products = new List<ProductViewModel>();
        foreach (var product in list)
        {
            products.Add(ToProductViewModel(product));
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
            Sex = product.Sex,
            ImagePath = product.ImagePath,
            Category = product.Category,
            Color = product.Color,
            Size = product.Size,
        };
    }


    public static List<Product> ToProductsDB(List<ProductViewModel> list)
    {
        var products = new List<Product>();
        foreach (var product in list)
        {
            products.Add(ToProductDB(product));
        }
        return products;
    }
    public static Product ToProductDB(ProductViewModel productVM)
    {
        return new Product
        {
            Id = productVM.Id,
            Name = productVM.Name,
            Description = productVM.Description,
            Price = productVM.Price,
            Quantity = productVM.Quantity,
            Sex = productVM.Sex,
            ImagePath = productVM.ImagePath,
            Category = productVM.Category,
            Color = productVM.Color,
            Size = productVM.Size,
        };
    }
}
