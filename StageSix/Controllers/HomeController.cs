
namespace StageSix.Controllers;

[Route("home")]
public class HomeController : Controller
{
    [Route("index")]//localhost:port/home/index
    [Route("")]//localhost:port/home
    [Route("~/")]
    public IActionResult Index() => View();

}
