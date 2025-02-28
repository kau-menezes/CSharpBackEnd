namespace Server.Application.Common.Interfaces;

using Server.Domain.Common;
using Server.Domain.Entities;
using Microsoft.EntityFrameworkCore;

public interface IApplicationDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}