using Server.Domain.Common;
using Server.Domain.Enums;

namespace Server.Domain.Entities;

public class Task : BaseAuditableEntity
{
    public required Guid ListId { get; set; }
    public Guid TaskId { get; set; }
    public string? Description { get; set; }
    public TaskStatusEnum? Status  { get; set; }

}