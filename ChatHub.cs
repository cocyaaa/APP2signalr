using Microsoft.AspNetCore.SignalR;

namespace APP2signalr
{
    public class ChatHub : Hub
    {
        public async Task SendMessageToAll( string message)
        {
            Console.WriteLine(message);
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}

