using StageFive.Models;

namespace StageFive.Services;

public interface IProductService
{
    // lấy tất cả sản phẩm
    List<Product> GetProducts();

    // lấy sản phẩm theo id
    Product? GetProductById(int id);

    // lọc theo giá
    List<Product> SortedByPrice(bool ascending = true);

    // tìm sản phẩm
    List<Product> SearchByKeyword(string keyword);

    // tìm sản phẩm theo tên
    List<Product> SearchByAnyKeyword (string keyword);
}
