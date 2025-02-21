namespace Exemple.Entities;

public class EntityB
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public required int EntityAId { get; set; }

    public EntityA? EntityA { get; set; }
}

