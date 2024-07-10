using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authorization;
using BlazorChatApp_2.Models;
using Microsoft.AspNetCore.SignalR.Client;
namespace BlazorChatApp_2.Hubs;

[Authorize]
public class ChatHub : Hub
{
    public async Task SendMessage(Message message, string reciever)
    {
        await Clients.All.SendAsync("ReceiveMessage", message);
        //await Clients.User(Context.UserIdentifier).SendAsync("ReceiveMessage", message);
    }
}