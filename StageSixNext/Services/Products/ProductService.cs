namespace StageSix.Services.Products;

public class ProductService : IProductService
{
    public IEnumerable<Product> GetProducts() => [
        new Product { Id = 1, Name = "Tivi", Price = 30000000, Quantity = 100, Status = true, Mfg = DateTime.Now, Photo = "hinh1.gif" },
        new Product { Id = 2, Name = "Laptop", Price = 25000000, Quantity = 100, Status = false, Mfg = DateTime.Now, Photo = "hinh2.gif" },
        new Product { Id = 3, Name = "Computer", Price = 20000000, Quantity = 100, Status = true, Mfg = DateTime.Now, Photo = "hinh3.gif" },
    ];

    public Product? GetProductById(int id) => GetProducts().FirstOrDefault(p => p.Id == id);

    public List<Product> FilterByAnyKeyword(string keyword) => [.. GetProducts().Where(p =>
    typeof(Product).GetProperties().Any(prop =>prop.GetValue(p)?.ToString()?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true))];
}