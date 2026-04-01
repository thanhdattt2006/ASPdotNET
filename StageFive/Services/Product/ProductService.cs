using StageFive.Models;

namespace StageFive.Services;

public class ProductService : IProductService
{
    public readonly List<Product> list = [
        new Product { Id = 1, Quantity = 5, Name = "Laptop", Price = 999.99, Mfg = DateTime.Now, Status = true },
        new Product { Id = 2, Quantity = 8, Name = "Smartphone", Price = 499.99, Mfg = DateTime.Now, Status = true},
        new Product { Id = 3, Quantity = 0, Name = "Headphones", Price = 199.99, Mfg = DateTime.Now, Status = false},
        new Product { Id = 4, Quantity = 10, Name = "Smartwatch", Price = 299.99, Mfg = DateTime.Now, Status = true },
        new Product { Id = 5, Quantity = 6, Name = "Tablet", Price = 399.99, Mfg = DateTime.Now, Status = true },
    ];

    public List<Product> GetProducts() => list;


    public Product? GetProductById (int id) => list.SingleOrDefault(p => p.Id == id);

    public List<Product> SearchByKeyword(string keyword) 
        => String.IsNullOrWhiteSpace (keyword) ? list : [.. list.Where(p => p.Name != null && p.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase))];

    public List<Product> SortedByPrice(bool ascending = true)
        => [.. list.OrderBy(p => ascending ? p.Price : -p.Price)];
    // list.OrderBy(p => ascending ? p.Price : -p.Price).ToList();
    // ascending ? list.OrderBy(p => p.Price).ToList() : list.OrderByDescending(p => p.Price).ToList();

    public List<Product> SearchByAnyKeyword(string keyword)
 => String.IsNullOrWhiteSpace(keyword) ? list : [.. list.Where(p =>
typeof(Product).GetProperties().Any(prop =>prop.GetValue(p)?.ToString()?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true))];
}
