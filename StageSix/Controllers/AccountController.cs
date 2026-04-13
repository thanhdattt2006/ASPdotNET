using Microsoft.AspNetCore.Mvc;

namespace StageSix.Controllers;

[Route("Account")]
public class AccountController (IAccountService acc) : Controller
{
    [Route("Login")]
    [Route("")]
    [HttpGet("~/")]
    public IActionResult Login() => View();

    [HttpPost("Login")]
    public IActionResult Login (string username, string password)
    {
        if (acc.Login(username, password))
        {
            TempData["Message"] = "Login successful";
            return RedirectToAction(nameof(Login));
        }

        ViewBag.Error = "Invalid username or password";
        return View();
    }

    [HttpGet("Register")]
    public IActionResult Register() => View();

    [HttpPost("Register")]
    public IActionResult Register(string username, string password)
    {
        string result = acc.Register(username, password);
        if (result.Contains("Success"))
        {
            TempData["Message"] = "Registritation done!";
            return RedirectToAction(nameof(Login));
        }

        ViewBag.Error = "Failed";
        return View();  
    }

}
