using BlazorChatApp_2.Data;
namespace BlazorChatApp_2.Models;

public class Chat
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public List<ApplicationUser>? Members { get; set; }
    public List<Message>? Messages { get; set; }
    public Chat() { }
    public Chat(string name, string? description, params ApplicationUser[] members)
    {
        Name = name;
        Description = description;
        Members = members.ToList();
    }
}
