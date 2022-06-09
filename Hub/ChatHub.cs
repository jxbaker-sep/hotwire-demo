using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", @$"
              <turbo-stream action='append' target='messages'>
                <template>
                  <p>{message}</p>
                </template>
              </turbo-stream>
            ");
        }
    }
}