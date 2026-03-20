using Microsoft.AspNetCore.Mvc;

namespace StageThree.Controllers;

public class ReviewViewBagController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Number = 20;
        ViewBag.Id = 1;
        ViewBag.Status = true;
        ViewBag.Quantity = 10;
        ViewBag.Price = 500000;
        ViewBag.Name = "RTX 5090";
        ViewBag.Mfg = DateTime.Now;
        ViewBag.Array = new[] { 1, 2, 3, 4, 5 };
        ViewBag.Photo = "/images/info.svg";
        ViewBag.Message = "Hello, welcome to the ViewBag review page!";
        ViewBag.AnnoymousObject = new { Id = 2, Name = "RTX 5090 White Alien Monster Collection", Status = false, Photo = "~/images/user.svg" };
        return View("Index");
    }

    public IActionResult ProductAndListProduct()
    {
        ViewBag.Product = new Models.Product()
        {
            Id = 1,
            Name = "Product 1",
            Price = 3000000,
            Quantity = 10,
            Status = true,
            Photo = "/images/user.svg"
        };
    }
}
