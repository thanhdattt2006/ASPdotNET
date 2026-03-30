using Microsoft.AspNetCore.Mvc;
using StageFive.Services;

namespace StageFive.Controllers;

[Route("calc")]
public class CalcController(ICalcService calcService, ITestService testService) : Controller
{
    
    [Route("")]
    [Route("index")]
    public IActionResult Index()
    {
        ViewBag.Sum = calcService.Sum(1, 2);
        ViewBag.Mul = calcService.Multiply(3, 4);
        ViewBag.Message = testService.GetMessage();
        ViewBag.Fullname = testService.GetFullName("Dave");
        return View();
    }
}
