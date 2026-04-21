namespace StageSix.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize(Roles = "Admin")]
public abstract class AdminControllerBase : Controller
{
}
