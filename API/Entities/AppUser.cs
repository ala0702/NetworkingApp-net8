namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }

    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }

    // profile info
    public required string UserName { get; set; }
    public string? Email { get; set; }
    public string? ProfilePictureUrl { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime LastLogin { get; set; }

    // for statistics??
    public int TotalTravels { get; set; }
    public double TotalDistanceTraveled { get; set; }

    // connection to its wishlist


    // relaltionships

    // public ICollection<UserFollower> Followers { get; set; } = new List<UserFollower>();
    // public ICollection<UserFollower> Following { get; set; } = new List<UserFollower>();

}