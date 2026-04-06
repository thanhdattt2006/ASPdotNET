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
}