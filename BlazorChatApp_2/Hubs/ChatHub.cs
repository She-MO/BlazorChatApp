using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authorization;
using BlazorChatApp_2.Models;
using Microsoft.AspNetCore.SignalR.Client;
namespace BlazorChatApp_2.Hubs;

[Authorize]
public class ChatHub : Hub
{
    public async Task SendMessage(string message, string[] recievers)
    {
        if (recievers is not null)
        {
            await Clients.Users(recievers).SendAsync("ReceiveMessage", message);
            //await Clients.All.SendAsync("ReceiveMessage", message);

        }

    }
    public async Task SendMessage2(Message message, string[]? recievers)
    {
        if (recievers is not null)
        {
            await Clients.Users(recievers).SendAsync("ReceiveMessage2", message);
            //await Clients.All.SendAsync("ReceiveMessage", message);
        }

    }
    public async Task SendNewChat(Models.Chat newChat, params string[] recievers)
    {
        await Clients.Users(recievers).SendAsync("AddChat", newChat);
    }
}