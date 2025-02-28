using System.ComponentModel.DataAnnotations.Schema;
using TemplateArchDemo.Domain.Common;

namespace Server.Domain.Common;

// all from the template

public abstract class BaseEntity<T>
{
    public required T Id { get; set; } = default!;

    private readonly List<BaseEvent> _domainEvents = new();

    [NotMapped]
    public IReadOnlyCollection<BaseEvent> DomainEvents => _domainEvents.AsReadOnly();

    public void AddDomainEvent(BaseEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }

    public void RemoveDomainEvent(BaseEvent domainEvent)
    {
        _domainEvents.Remove(domainEvent);
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }
}
