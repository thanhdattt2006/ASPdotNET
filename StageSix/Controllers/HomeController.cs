using Microsoft.AspNetCore.Mvc;

namespace StageSeven.Controllers;

[Route("home")]
public class HomeController : Controller
{
  [Route("index")]
  [Route("")]
  public IActionResult Index() => View();
}
