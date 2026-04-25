namespace StageSeven.Controllers;

[Route("san-pham")]
public class ProductController(IProductService pro) : Controller
{
  [Route("danh-sach")] //localhost:port/Product/Index sẽ vào đây
  [Route("")] //action mặc định localhost:port/Product sẽ vào đây
  [HttpGet("~/")] //override default route, localhost:port/ sẽ vào đây
  public IActionResult Index() => View(pro.GetProducts());

  //truyền theo dang query string: localhost:port/san-pham/chi-tiet?id=1
  [Route("chi-tiet")]
  public IActionResult Details(int id) => View("Details", pro.GetProductById(id));

  [HttpGet("tim-kiem")]
  public IActionResult Search(string search)
  {
    IEnumerable<Product> products = string.IsNullOrEmpty(search) ? pro.GetProducts() : pro.FilterByAnyKeyword(search);

    return View("Index", products);
  }

  [HttpGet("auto-complete", Name = "AutoComplete")]
  public IActionResult AutoComplete(string term)
  {
    IEnumerable<string?> find = pro.GetProducts()
      .Where(p => p.Name?.Contains(term, StringComparison.OrdinalIgnoreCase) == true)
      .Select(p => p.Name)
      .Distinct();
    return Json(find);
  }
}
