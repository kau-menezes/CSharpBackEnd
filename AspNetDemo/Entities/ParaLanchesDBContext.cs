using Microsoft.EntityFrameworkCore;

namespace Server.Entities;

public class ParaLanchesDBContext(DbContextOptions<ParaLanchesDBContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>()
            .HasMany( e => e.InviteUsers)
            .WithOne(e => e.InvitedBy)
            .HasForeignKey( e=> e.InvitedByUserId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.Entity<User>()
            .HasOne( e => e.InvitedBy)
            .WithMany( e=> e.InviteUsers)
            .HasForeignKey( e => e.InvitedByUserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}