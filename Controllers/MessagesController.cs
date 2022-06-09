using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using SignalRChat.Hubs;

namespace hotwire_demo.Controllers;
public class MessagesController : Controller {

  public MessagesController(IHubContext<ChatHub> chatHub) {
    _chatHub = chatHub;
  }

  static public List<String> messages = new List<String>();
  private IHubContext<ChatHub> _chatHub;

  [HttpGet("~/messages")]
  public async Task<IActionResult> IndexAsync(string message) {
    Console.WriteLine(message);
    messages.Add(message);
    await _chatHub.Clients.All.SendAsync("ReceiveMessage", @$"
              <turbo-stream action='append' target='messages'>
                <template>
                  <p>{message}</p>
                </template>
              </turbo-stream>
            ");
    return Ok();
  }
}