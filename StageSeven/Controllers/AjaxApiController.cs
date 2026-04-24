using Microsoft.AspNetCore.Mvc;

namespace StageSeven.Controllers;

[Route("ajaxapi")]
public class AjaxApiController : Controller
{
    [Route("")]
    [Route("index")]
    [HttpGet("~/")]
    public IActionResult Index() => View();

    [HttpGet("message-json-async")]
    public async Task<IActionResult> MessageJsonAsync()
    => await Task.FromResult(Json(new { message = "Ajax: Hello World Json Async!" }));
}
