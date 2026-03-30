using Microsoft.AspNetCore.Mvc;
using StageFive.Services;

namespace StageFive.Controllers;

[Route("test")] // localhost:xxxx/test
[Route("")] // localhost:xxxx
public class TestController : Controller
{
    // DI dependency injection
    public readonly ITestService _testService;

    public TestController (ITestService testService)
    {
        _testService = testService;
    }

    [Route("")]
    [Route("index")] // localhost:xxxx/test/index
    public IActionResult Index()
    {
        ViewBag.Message = _testService.GetMessage();
        return View();
    }

    [Route("index1/{fullname?}")]
    public IActionResult Index1 (string? fullname)
    {
        ViewBag.Fullname = _testService.GetFullName(fullname ?? "");
        return View();
    }
}
