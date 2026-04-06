

namespace StageSix.Services.Products;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
    public Product? GetProductById(int id);
}
