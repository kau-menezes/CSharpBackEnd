using Server.Domain.Common;

namespace Server.Domain.Entities;

public class AppUser : BaseAuditableEntity
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }

    public ICollection<ToDoList>? ToDoLists { get; set; }

}