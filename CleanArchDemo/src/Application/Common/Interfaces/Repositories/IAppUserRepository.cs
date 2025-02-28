using Server.Domain.Entities;

namespace Server.Application.Interfaces.Repositories;

public interface IAppUserRepository
{
    Task<AppUser?> GetByIdAsync(Guid userId);
    Task<AppUser?> GetByNameAsync(string name);
    Task AddAsync(AppUser user);
    Task UpdateAsync(AppUser user);
    Task DeleteAsync(AppUser user);
}