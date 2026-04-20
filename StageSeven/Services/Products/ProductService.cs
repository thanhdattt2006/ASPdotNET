namespace StageSeven.Services.Products;

public class ProductService : IProductService
{
  public IEnumerable<Product> GetProducts() => [
    new Product{Id = 1, Name = "ao", Price = 10.0, Quantity = 5, Status = true, Mfg = DateTime.Now, Photo = "hinh1.gif"},
    new Product{Id = 2, Name = "quan", Price = 20.0, Quantity = 10, Status = false, Mfg = DateTime.Now, Photo = "hinh2.gif"},
    new Product{Id = 3, Name = "khan", Price = 30.0, Quantity = 15, Status = true, Mfg = DateTime.Now, Photo = "hinh3.gif"},
  ];

  public Product? GetProductById(int id) => GetProducts().FirstOrDefault(p => p.Id == id);

  public List<Product> FilterByAnyKeyword(string keyword)
    =>
    [.. GetProducts().Where(p =>
        typeof(Product).GetProperties().Where(prop => prop.Name != nameof(Product.Status)).Any(prop =>
            prop.GetValue(p)?.ToString()?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true)
    )];
}
