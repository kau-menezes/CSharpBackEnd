// using Server.Application.Common.Interfaces.Repositories;
using Server.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Server.Application.Interfaces.Repositories;
using Server.Application.Common.Interfaces;

namespace Server.Infrastructure.Data
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly IApplicationDbContext _context;

        public AppUserRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<ApplicationUser?> GetByIdAsync(Guid userId)
        {
            return await _context.Users
                .FirstOrDefaultAsync(user => user.Id == userId);
        }

        public async Task<ApplicationUser?> GetByNameAsync(string username)
        {
            return await _context.Users
                .FirstOrDefaultAsync(user => user.Name == username);
        }

        public async Task AddAsync(ApplicationUser user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task UpdateAsync(ApplicationUser user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync(CancellationToken.None);
        }

        public async Task DeleteAsync(ApplicationUser user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync(CancellationToken.None);
        }


    }
}