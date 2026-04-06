

namespace StageSix.Controllers;

[Route("san-pham")]

public class ProductController(IProductService pro) : Controller
{
    [Route("danh-sach")]//localhost:port/product/index
    [Route("")]//localhost:port/product
    //[Route("~/")]//localhost:port
    public IActionResult Index() => View(pro.GetProducts());

    [Route("chi-tiet")]//truyen theo dang query string: localhost:port/san-pham/chi-tiet?id=1
    public IActionResult Details(int id) => View(pro.GetProductById(id));
}
