using Microsoft.AspNetCore.Identity;
using BlazorChatApp_2.Models;
namespace BlazorChatApp_2.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public List<Message>? messages = new();
    public string Nickname { get; set; }
}
