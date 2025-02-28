namespace Server.Application.Common.Interfaces;

using Server.Domain.Common;
using Server.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public interface IApplicationDbContext
{
    DbSet<AppUser> Users { get; set; }  // Define Users DbSet here
    DbSet<ToDoList> ToDoLists { get; set; }
    DbSet<TaskItem> Tasks { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}