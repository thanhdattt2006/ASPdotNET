namespace StageSeven.Services.Products;

public class ProductService : IProductService
{
    // Phải để static nó mới lưu được tạm thời trong RAM
    private static List<Product> _products = new()
    {
        new Product{Id = 1, Name = "ao", Price = 10.0, Quantity = 5, Status = true, Mfg = DateTime.Now, Photo = "hinh1.gif"},
        new Product{Id = 2, Name = "quan", Price = 20.0, Quantity = 10, Status = false, Mfg = DateTime.Now, Photo = "hinh2.gif"},
        new Product{Id = 3, Name = "khan", Price = 30.0, Quantity = 15, Status = true, Mfg = DateTime.Now, Photo = "hinh3.gif"}
    };

    public IEnumerable<Product> GetProducts() => _products;

    public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

    public List<Product> FilterByAnyKeyword(string keyword)
        => [.. _products.Where(p =>
            typeof(Product).GetProperties().Where(prop => prop.Name != nameof(Product.Status)).Any(prop =>
                prop.GetValue(p)?.ToString()?.Contains(keyword, StringComparison.OrdinalIgnoreCase) == true)
        )];

    public void AddProduct(Product p)
    {
        p.Id = _products.Any() ? _products.Max(x => x.Id) + 1 : 1;
        _products.Add(p);
    }

    public void UpdateProduct(Product p)
    {
        var existing = GetProductById(p.Id);
        if (existing != null)
        {
            existing.Name = p.Name;
            existing.Price = p.Price;
            existing.Quantity = p.Quantity;
            existing.Status = p.Status;
            existing.Mfg = p.Mfg;
            existing.Photo = p.Photo; // Kệ mẹ cái ảnh đi, code phèn ko cần upload
        }
    }

    public void DeleteProduct(int id)
    {
        var p = GetProductById(id);
        if (p != null) _products.Remove(p);
    }
}