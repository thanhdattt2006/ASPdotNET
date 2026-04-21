

namespace StageSix.Controllers;

[Route("Form")] //localhost:xxxx/form
public class FormController : Controller
{
  [Route("index")] //localhost:xxxx/form/index
  [Route("")] //localhost:xxxx/form => default action 
  //[HttpGet("~/")] //localhost:xxxx/ => override default route
  public IActionResult Index() => View();

  [HttpGet("show-name")] //localhost:xxxx/form/show-name
  public IActionResult ShowName(string fullname) => View(model: fullname);

  [HttpGet("show-name-and-quantity")] //localhost:xxxx/form/show-name-and-quantity
  public IActionResult ShowNameandQuantity(string fullname, int quantity)
  {
    ViewBag.FullName = fullname;
    ViewBag.Quantity = quantity;
    return View();
  }

  [HttpGet("show-name-and-quantity-by-request-query")]
  public IActionResult ShowNameandQuantityByRequestQuery()
  {
    //Request.Query luôn trả về chuỗi
    ViewBag.Fullname = Request.Query["fullname"];
    ViewBag.Quantity = int.Parse(Request.Query["quantity"].ToString());
    return View("ShowNameandQuantity");
  }


  [HttpPost("show-name-and-quantity-by-request-form")]
  public IActionResult ShowNameandQuantityByRequestForm()
  {
    //Request.Form luôn trả về chuỗi
    ViewBag.Fullname = Request.Form["fullname"];
    ViewBag.Quantity = int.Parse(Request.Form["quantity"].ToString());
    return View("ShowNameandQuantity");
  }

  [HttpPost("show-product")]
  public IActionResult ShowProduct(Product pro) => View(pro);

  [HttpPost("show-product-by-viewmodel")]
  public IActionResult ShowProductVM(ProductViewModel pro) => View(pro);

  [HttpPost("show-hobbies")]

  //public IActionResult ShowHobbies(string[] hobbies)
  //do bên cshtml name trùng tên nên trong asp.net core
  //sẽ tự động map vào List<string> hobbies
  //hoặc là mảng string[] hobbies đều được
  public IActionResult ShowHobbies(List<string> hobbies)
  {
    ViewBag.Hobbies = hobbies;
    return View();
  }

  [HttpPost("show-emails")]
  public IActionResult ShowEmails(string[] emails)
  {
    ViewBag.Emails = emails;
    return View();
  }

  [HttpPost("show-date")]
  public IActionResult ShowDate(string dob)
  {
    string[] formats =["dd/MM/yyyy", "d/M/yyyy", "dd-MM-yyyy"];
    CultureInfo vi = new("vi-VN");
    bool success =
      DateTime.TryParseExact(dob, formats, vi, DateTimeStyles.None, out DateTime parsed)
      ||
      DateTime.TryParseExact(dob, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsed);

    if(!success)
    {
      ViewBag.Error = "không thể chuyển đổi ngày thành công";
      return View();
    }

    ViewBag.Dob = parsed;
    return View();
  }
}