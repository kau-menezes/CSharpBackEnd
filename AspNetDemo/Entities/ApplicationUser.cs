namespace Server.Entities;

public class AplicationUser
{
    public Guid Id { get; set; }= Guid.NewGuid();
    public required string Name { get; set; }
    public required string Email { get; set; }


}