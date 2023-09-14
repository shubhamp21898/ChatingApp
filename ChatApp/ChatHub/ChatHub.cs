using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace ChatApp.ChatHub
{
    
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            // Broadcast the message to all connected clients (including the caller).
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }

}
