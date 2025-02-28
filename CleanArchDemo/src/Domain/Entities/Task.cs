using Server.Domain.Common;
using Server.Domain.Enums;

namespace Server.Domain.Entities;

public class TaskItem : BaseAuditableEntity
{
    public required Guid ListId { get; set; }
    public required ToDoList ToDoList { get; set; }
    public Guid TaskId { get; set; }
    public string? Description { get; set; }
    public TaskStatusEnum? Status  { get; set; }

}