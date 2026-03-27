using Microsoft.AspNetCore.Mvc;

namespace StageFour.Controllers;

[Route("product")]
public class ProductController : Controller
{
    // [Route("")] // lỗi, trùng action index bên HomeController
    [Route("/")] // tuyệt đối lấy localhost:xxxx/
    [Route("index")]
    public IActionResult Index() => View();

    [Route("index1/{id?}")]
    public IActionResult Index1(int? id)
    {
        ViewBag.Id = id;
        return View();
    }

    [Route("index2/{name?}/{age?}")]
    public IActionResult Index2 (string? name, int? age)
    {
        ViewBag.Name = name;
        ViewBag.Age = age;
        return View();
    }

    [Route("index3")]
    public IActionResult Index3(string? name, int? age)
    {
        ViewBag.Name = name;
        ViewBag.Age = age;
        return View();
    }

    //[Route("index4/{id:alpha?}")]
    [Route("index4/{id:regex(^[[a-zA-Z]]+$)?}")]
    public IActionResult Index4(string? id)
    {
        ViewBag.Id = id;
        return View();
    } 
}
