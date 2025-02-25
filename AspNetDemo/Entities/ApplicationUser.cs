namespace Server.Entities;

public class ApplicationUser
{
    public Guid Id { get; set; }= Guid.NewGuid();
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public Guid? InvitedByUserId { get; set; } 
    public ApplicationUser? InvitedBy { get; set; }
    public ICollection<ApplicationUser>? InviteUsers { get; set; }


}