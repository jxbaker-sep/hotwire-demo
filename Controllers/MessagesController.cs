using Microsoft.AspNetCore.Mvc;
namespace hotwire_demo.Controllers;
public class MessagesController : Controller {
  [HttpGet("~/messages")]
  public IActionResult Index() {
    Console.WriteLine("Hello world");
    return View();
  }
}