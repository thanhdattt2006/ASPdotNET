namespace StageSeven.Controllers;

[Route("ajaxget")]
public class AjaxgetController : Controller
{
  //[HttpGet("~/")]
  [Route("index")]
  [Route("")]
  public IActionResult Index() => View();

  [HttpGet("message")]
  public IActionResult Message() => Content("Ajax: Hello World!");

  [HttpGet("message-json")]
  public IActionResult MessageJson()
    => Json(new { message = "Ajax: Hello World Json!" });

  [HttpGet("message-json-async")]
  public async Task<IActionResult> MessageJsonAsync()
   => Json(new { message = "Ajax: Hello World Json Async!" });
   

  //truyền theo route localhost:xxx/ajaxget/get-name/yourname
  [HttpGet("get-name/{name}")]
  public IActionResult GetName(string name)
    => Json(new { fullname = $"hello, {name}" });

  //truyền theo route localhost:xxx/ajaxget/get-name-query?name=yourname
  [HttpGet("get-name-query")]
  public IActionResult GetNameQuery(string name)
    => Json(new { fullname = $"hello, {name}" });
}
