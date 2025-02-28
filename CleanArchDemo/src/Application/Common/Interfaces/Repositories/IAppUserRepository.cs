using Server.Domain.Entities;

namespace Server.Application.Interfaces.Repositories;

public interface IAppUserRepository
{
    Task<ApplicationUser?> GetByIdAsync(Guid userId);
    Task<ApplicationUser?> GetByNameAsync(string name);
    Task AddAsync(ApplicationUser user);
    Task UpdateAsync(ApplicationUser user);
    Task DeleteAsync(ApplicationUser user);
}