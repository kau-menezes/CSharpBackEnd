using Server.Domain.Common;
using Server.Domain.Enums;

namespace Server.Domain.Entities;

public class ToDoList : BaseAuditableEntity
{
    public ICollection<TaskItem>? Tasks { get; set; }
    public string? Description { get; set; }
    public required ApplicationUser Owner  { get; set; }
    public required Guid OwnerId  { get; set; }


}