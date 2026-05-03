namespace StageSeven.Controllers;

[Route("san-pham")]
public class ProductController(IProductService pro) : Controller
{
    //  check session
    private bool IsAuth() => HttpContext.Session.GetString("User") == "sa";

    [Route("danh-sach")]
    [Route("")]
    [HttpGet("~/")]
    public IActionResult Index()
    {
        if (!IsAuth()) return RedirectToAction("Index", "Login");
        return View(pro.GetProducts());
    }

    [Route("chi-tiet")]
    public IActionResult Details(int id)
    {
        if (!IsAuth()) return RedirectToAction("Index", "Login");
        return View("Details", pro.GetProductById(id));
    }

    [HttpGet("them-moi")]
    public IActionResult Create()
    {
        if (!IsAuth()) return RedirectToAction("Index", "Login");
        return View();
    }

    [HttpPost("them-moi")]
    public IActionResult Create(Product p)
    {
        if (!IsAuth()) return RedirectToAction("Index", "Login");
        if (ModelState.IsValid)
        {
            p.Mfg = DateTime.Now;
            pro.AddProduct(p);
            return RedirectToAction("Index");
        }
        return View(p);
    }

    [HttpGet("sua/{id}")]
    public IActionResult Edit(int id)
    {
        if (!IsAuth()) return RedirectToAction("Index", "Login");
        var product = pro.GetProductById(id);
        if (product == null) return NotFound();
        return View(product);
    }

    [HttpPost("sua/{id}")]
    public IActionResult Edit(Product p)
    {
        if (!IsAuth()) return RedirectToAction("Index", "Login");
        if (ModelState.IsValid)
        {
            pro.UpdateProduct(p);
            return RedirectToAction("Index");
        }
        return View(p);
    }

    [HttpGet("xoa/{id}")]
    public IActionResult Delete(int id)
    {
        if (!IsAuth()) return RedirectToAction("Index", "Login");
        pro.DeleteProduct(id);
        return RedirectToAction("Index");
    }

    [HttpGet("tim-kiem")]
    public IActionResult Search(string search)
    {
        if (!IsAuth()) return RedirectToAction("Index", "Login");
        IEnumerable<Product> products = string.IsNullOrEmpty(search) ? pro.GetProducts() : pro.FilterByAnyKeyword(search);
        return View("Index", products);
    }

    [HttpGet("auto-complete", Name = "AutoComplete")]
    public IActionResult AutoComplete(string term)
    {
        if (!IsAuth()) return Unauthorized();
        IEnumerable<string?> find = pro.GetProducts()
            .Where(p => p.Name?.Contains(term, StringComparison.OrdinalIgnoreCase) == true)
            .Select(p => p.Name)
            .Distinct();
        return Json(find);
    }
}