namespace StageSeven.Controllers;

[Route("ajaxapi")]
public class AjaxapiController : Controller
{
  [Route("")]
  [Route("index")]
  //[HttpGet("~/")]
  public IActionResult Index() => View();

  //thuộc tính Name thường trùng với tên phương thức (action)
  //nhưng có thể khác nếu muốn
  [HttpGet("message-json-async", Name = "MessageJsonAsync")]
  public IActionResult MessageJsonAsync()
  => Json(new { message = "Ajax: Hello World Json Async!" });

  [HttpGet("get-name-query", Name = "GetNameQuery")]
  public IActionResult GetNameQuery(string name)
  => Json(new { fullname = $"hello, {name}" });

  [HttpPost("get-person", Name = "GetPerson")]
  public IActionResult GetPerson([FromBody] PersonVM person)
    => person is null
      ? BadRequest("Person data is required.")
      : !ModelState.IsValid ? BadRequest(ModelState) : Ok(new { fullname = person.Name, age = person.Age });

}
