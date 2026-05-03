namespace StageSeven.Services.Products;

public interface IProductService
{
    IEnumerable<Product> GetProducts();
    Product? GetProductById(int id);
    List<Product> FilterByAnyKeyword(string keyword);
    void AddProduct(Product p);
    void UpdateProduct(Product p);
    void DeleteProduct(int id);
}
