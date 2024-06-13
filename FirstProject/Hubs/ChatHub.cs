using Microsoft.AspNetCore.SignalR;

namespace FirstProject.Hubs
{
    public class ChatHub:Hub
    {

        public async Task SendMessaceAsync(string message)
        {

            await Clients.All.SendAsync("receiveMessage", message);

        }
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("UserConnect", Context.ConnectionId);


        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Clients.All.SendAsync("UserDisconnect", Context.ConnectionId);
        }
         
    }
}
