using BlazorChatApp_2.Data;
using System.Security.Claims;
namespace BlazorChatApp_2.Models;

public class Message
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime DateTime { get; set; }
    public string SenderId { get; set; }
    public ApplicationUser Sender { get; set; }
    public int? ChatId { get; set; }
    public Chat? Chat { get; set; }
    public int? RepliedToMessageWithId { get; set; }
    public Message? RepliedToMessage { get; set; }
    public Message() { }
    public Message(string text, DateTime dateTime, ApplicationUser user, int chatId)
    {
        Text = text;
        DateTime = dateTime;
        SenderId = user.Id;
        ChatId = chatId;
    }

}
