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
    public Message() { }
    public Message(string text, DateTime dateTime, ApplicationUser user)
    {
        Text = text;
        DateTime = dateTime;
        Sender = user;
        SenderId = user.Id;
    }

}
