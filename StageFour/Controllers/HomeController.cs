using Microsoft.AspNetCore.Mvc;

namespace StageFour.Controllers;

[Route("home")]

public class HomeController : Controller
{
    #region ex
    //public IActionResult Index(int? id)
    //{
    //    ViewBag.Id = id;
    //    return View();
    //}

    //public IActionResult Index1 (string? fullname, bool? gender)
    //{
    //    ViewBag.Fullname = fullname;
    //    ViewBag.Gender = gender;
    //    return View();
    //}
    #endregion
    [Route("")] // default action
    [Route("index")]
    public IActionResult Index() => View();

    [Route("index1")]
    public IActionResult Index1() => View();
}
