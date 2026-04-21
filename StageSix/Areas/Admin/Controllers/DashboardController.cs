namespace StageSix.Areas.Admin.Controllers;

[Route("Admin")]
public class DashboardController : AdminControllerBase
{
  [HttpGet("Dashboard")]
  [Route("")]
  public IActionResult Index() => View();
}
