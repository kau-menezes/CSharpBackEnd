using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Server.Entities;

public class ParaLanchesDBContext(DbContextOptions<ParaLanchesDBContext> options) : DbContext(options)
{
    public DbSet<AplicationUser> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}