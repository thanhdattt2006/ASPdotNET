

namespace StageSix.Services.Products;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
    Product? GetProductById(int id);
    List<Product> FilterByAnyKeyword(string keyword);
}
