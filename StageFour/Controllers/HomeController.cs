using Microsoft.AspNetCore.Mvc;

namespace StageFour.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(int? id)
    {
        ViewBag.Id = id;
        return View();
    }

    public IActionResult Index1 (string? fullname, bool? gender)
    {
        ViewBag.Fullname = fullname;
        ViewBag.Gender = gender;
        return View();
    }
}
