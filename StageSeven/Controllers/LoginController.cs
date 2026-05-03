namespace StageSeven.Controllers;

[Route("login")]
public class LoginController : Controller
{
    [HttpGet("")]
    public IActionResult Index() => View();

    [HttpPost("")]
    public IActionResult Index(string username, string password)
    {
        if (username == "sa" && password == "1234567")
        {
            HttpContext.Session.SetString("User", "sa");
            return RedirectToAction("Index", "Product");
        }
        ViewBag.Error = "Sai pass hoặc username rồi con gà!";
        return View();
    }

    [HttpGet("thoat")]
    public IActionResult Logout()
    {
        HttpContext.Session.Remove("User");
        return RedirectToAction("Index");
    }
}