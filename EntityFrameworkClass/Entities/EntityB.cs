namespace Exemple.Entities;

public class EntityB
{
    public int Id { get; set; }
    public string? Name { get; set; }


    public ICollection<EntityA> EntityAs { get; set; } = [];
}

