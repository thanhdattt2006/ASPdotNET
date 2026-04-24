

namespace StageSeven.Controllers;

[Route("ajaxpost")]
public class AjaxpostController : Controller
{
  [Route("index")]
  [Route("")]
  [HttpGet]
  public IActionResult Index() => View();

  [HttpPost("get-name")]
  public IActionResult GetName([FromBody] string name)
    => Json(new { fullname = $"hello, {name}" });

  [HttpPost("get-person")]
  public async Task<IActionResult> GetPerson([FromBody] PersonVM person)
  {
    if(person is null)
      return BadRequest("Person data is required.");

    if(!ModelState.IsValid)
      return BadRequest(ModelState);
    //thường dùng cho mvc
    //return Json(new { fullname = person.Name, age = person.Age });

    //thường dùng cho web api, vì nó trả về trang thái http, còn json chỉ là dữ liệu
    return await Task.FromResult(Ok(new { fullname = person.Name, age = person.Age }));
  }
}
