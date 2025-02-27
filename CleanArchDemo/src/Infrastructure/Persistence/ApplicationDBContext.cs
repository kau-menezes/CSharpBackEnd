using Server.Application.Common.Interfaces;
using Server.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Server.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<ApplicationUser> Users { get ; set ; }
    public DbSet<ToDoList> ToDoLists { get ; set ; }
    public DbSet<TaskItem> Tasks { get ; set ; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationUser>()
            .HasMany( e => e.ToDoLists)
            .WithOne( e => e.Owner)
            .HasForeignKey( e => e.OwnerId);


        builder.Entity<ToDoList>()
            .HasMany( e => e.Tasks)
            .WithOne( e => e.ToDoList)
            .HasForeignKey( e => e.ListId);

    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}