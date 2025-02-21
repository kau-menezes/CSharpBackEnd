using Microsoft.EntityFrameworkCore;

namespace Exemple.Entities;

public class ExempleDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<EntityA> EntitiesAs { get; set; }
    public DbSet<EntityB> EntitiesBs { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // builder.Entity<EntityA>()
        //     .HasMany<EntityB>()
        //     .WithOne()


        builder.Entity<EntityA>()
            .HasMany( e => e.EntityBs)
            .WithOne( e => e.EntityA)
            .HasForeignKey( e => e.EntityAId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}