using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
namespace BlazorChatApp_2.CustomIdProvider
{
    public class ChatAppCustomIdProvider : IUserIdProvider
    {
        public string? GetUserId(HubConnectionContext connection)
        {
            return connection.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
