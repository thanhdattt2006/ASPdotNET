namespace StageSix.Controllers;

[Route("form")]//localhost:port/form
public class FormController : Controller
{
    [Route("index")]//localhost:port/form/index
    [Route("")]//localhost:port/form=>default action
    [HttpGet("~/")]//localhost:port => override default route
    public IActionResult Index() => View();
    [HttpGet("show-name")]//localhost:port/form/show-name
    public IActionResult ShowName(string fullname) => View(model: fullname);
    [HttpGet("show-name-and-quantity")]//localhost:port/form/show-name-and-quantity
    public IActionResult ShowNameAndQuantity(string fullname, int quantity)
    {
        ViewBag.fullname = fullname;
        ViewBag.quantity = quantity;

        return View();
    }
    [HttpGet("show-name-and-quantity-by-request-query")]//localhost:port/form/show-name-and-quantity-by-request-query
    public IActionResult ShowNameAndQuantityByRequestQuery()
    {
        //Request.Query luon tra ve chuoi
        ViewBag.fullname = Request.Query["fullname"];
        ViewBag.quantity = int.Parse(Request.Query["quantity"].ToString());

        return View("ShowNameAndQuantity");
    }
    [HttpPost("show-name-and-quantity-by-request-form")]//localhost:port/form/show-name-and-quantity-by-request-form
    public IActionResult ShowNameAndQuantityByRequestForm()
    {
        //Request.Form luon tra ve chuoi
        ViewBag.fullname = Request.Form["fullname"];
        ViewBag.quantity = int.Parse(Request.Form["quantity"].ToString());

        return View("ShowNameAndQuantity");
    }
    [HttpPost("show-product")]//localhost:port/form/show-product
    public IActionResult ShowProduct(Product pro) => View(pro);

    //[HttpPost("show-product-by-viewmodel")]
    //public IActionResult ShowProductVM(ProductViewModel pro) => View(pro);
    [HttpPost("show-hobbies")]
    //co 2 cach thi cach Mang nhanh hon nhung cach List se linh hoat hon
    //public IActionResult ShowHobbies(string[] hobbies)
    public IActionResult ShowHobbies(List<string> hobbies)
    //public IActionResult ShowHobbies(IFormCollection hobbies) //cach 3 nay it sd vi can phai them buoc khai bao kieu cho thuoc tinh 
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
    [HttpPost("show-dates")]
    public IActionResult ShowDate()
    {
        return View();
    }
}
