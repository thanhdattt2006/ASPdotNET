using Microsoft.AspNetCore.Mvc;

namespace StageSeven.Controllers;

[Route("ajaxapi")]
public class AjaxApiController : Controller
{
    [Route("")]
    [Route("index")]
    [HttpGet("~/")]
    public IActionResult Index() => View();

    [HttpGet("message-json-async", Name = "MessageJsonAsync")]
    public async Task<IActionResult> MessageJsonAsync()
    => await Task.FromResult(Json(new { message = "Ajax: Hello World Json Async!" }));

    [HttpGet("get-name-query", Name = "GetNameQuery")]
    public IActionResult GetNameQuery(string name) => Json(new { fullname = $"hello, {name}: " });

    [HttpPost("get-person", Name = "GetPerson")]
    public IActionResult GetPerson([FromBody] PersonVM person)
        => person is null
        ? BadRequest("Person data is required")
        : !ModelState.IsValid ? BadRequest(ModelState) : Ok(new { fullname = person.Name, age = person.Age });
}
