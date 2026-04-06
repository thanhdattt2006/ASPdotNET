using Microsoft.AspNetCore.Mvc;

namespace StageSix.Controllers;

[Route("Form")]
public class FormController : Controller
{
    [Route("index")]
    [Route("")]
    [HttpGet("~/")]
    public IActionResult Index() => View();

    [HttpGet("show-name")]
    public IActionResult ShowName(string fullname) => View(model: fullname);

    [HttpGet("show-name-and-quantity")]
    public IActionResult ShowNameAndQuantity(string fullname, int quantity) {
        ViewBag.FullName = fullname;
        ViewBag.Quantity = quantity;
        return View();
    }

    [HttpGet("show-name-and-quantity-request-query")]
    public IActionResult ShowNameAndQuantityRequestQuery()
    {
        ViewBag.FullName = Request.Query["fullname"];
        ViewBag.Quantity = int.Parse(Request.Query["quantity"].ToString());
        return View("ShowNameAndQuantity");
    }

    [HttpPost("show-name-and-quantity-request-form")]
    public IActionResult ShowNameAndQuantityRequestForm()
    {
        ViewBag.FullName = Request.Query["fullname"];
        ViewBag.Quantity = int.Parse(Request.Query["quantity"].ToString());
        return View("ShowNameAndQuantity");
    }
}


