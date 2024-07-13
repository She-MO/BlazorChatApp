using Microsoft.AspNetCore.Identity;
using BlazorChatApp_2.Models;
namespace BlazorChatApp_2.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser, IEquatable<ApplicationUser>
{
    public List<Models.Chat> Chats { get; set; } = new();
    public string Nickname { get; set; }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        ApplicationUser? objAsUser = obj as ApplicationUser;
        if (objAsUser == null) return false;
        else return Equals(objAsUser);
    }
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
    public bool Equals(ApplicationUser? other)
    {
        if (other == null) return false;
        return (this.Id.Equals(other.Id));
    }
}
