using Microsoft.EntityFrameworkCore;

namespace Exemple.Entities;

public class ExempleDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<EntityA> EntitiesAs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}