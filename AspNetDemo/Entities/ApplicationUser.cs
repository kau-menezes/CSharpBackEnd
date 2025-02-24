namespace Server.Entities;

public class User
{
    public Guid Id { get; set; }= Guid.NewGuid();
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public Guid? InvitedByUserId { get; set; }= Guid.NewGuid();
    public User? InvitedBy { get; set; }
    public ICollection<User>? InviteUsers { get; set; }


}