using Microsoft.AspNetCore.SignalR;
using BlazorChatApp_2.Models;
namespace BlazorChatApp_2.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(Message message)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
    }
}