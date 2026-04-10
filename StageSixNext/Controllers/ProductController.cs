

namespace StageSix.Controllers;

[Route("san-pham")]

public class ProductController(IProductService pro) : Controller
{
    [Route("danh-sach")]//localhost:port/product/index
    [Route("")]//localhost:port/product
    //[Route("~/")]//localhost:port
    //[HttpGet("~/")]//localhost:port
    public IActionResult Index() => View(pro.GetProducts());

    [Route("chi-tiet")]//truyen theo dang query string: localhost:port/san-pham/chi-tiet?id=1
    public IActionResult Details(int id) => View(pro.GetProductById(id));

    [HttpGet("tim-kiem")]//localhost:port/san-pham/tim-kiem?keyword=iphone
    public IActionResult Search(string search)//name ben phan form search o view index co name la search nen string search, chu k phai keyword
    {
        IEnumerable<Product> products = string.IsNullOrEmpty(search) ? pro.GetProducts() : pro.FilterByAnyKeyword(search);
        return View("Index", products);
    }
}
