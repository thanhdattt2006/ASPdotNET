using Microsoft.AspNetCore.Mvc;
using StageThree.Models;

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
        // viewbag chứa 1 đối tượng 
        ViewBag.Product = new Product()
        {
            Id = 2,
            Name = "Product 2",
            Photo = "hinh2.gif",
            Mfg = DateTime.Now,
            Status = true,
            Price = 19.99,
            Quantity = 100,
        };
        ViewBag.ListProduct = new List<Product>()
        {
            new()
            {
                Id = 3,
                Name = "Product 3",
                Photo = "hinh3.gif",
                Mfg = DateTime.Now,
                Status = true,
                Price = 29.99,
                Quantity = 100,
            },
            new()
            {
                Id = 4,
                Name = "Product 4",
                Photo = "hinh3.gif",
                Mfg = DateTime.Now,
                Status = true,
                Price = 39.99,
                Quantity = 100,
            },
        };
        return View("ProductAndListProduct");
    }
}
