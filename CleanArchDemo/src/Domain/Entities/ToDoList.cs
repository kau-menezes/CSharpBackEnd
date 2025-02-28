using Server.Domain.Common;
using Server.Domain.Enums;

namespace Server.Domain.Entities;

public class ToDoList : BaseAuditableEntity
{
    public ICollection<Task>? Tasks { get; set; }
    public string? Description { get; set; }
    public required AppUser Owner  { get; set; }


}