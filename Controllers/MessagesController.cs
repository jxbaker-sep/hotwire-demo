using Microsoft.AspNetCore.Mvc;
namespace hotwire_demo.Controllers;
public class MessagesController : Controller {
  static public List<String> messages = new List<String>();
  [HttpGet("~/messages")]
  public IActionResult Index(string message) {
    Console.WriteLine(message);
    messages.Add(message);
    return View(messages);
  }
}