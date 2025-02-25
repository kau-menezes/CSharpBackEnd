namespace Server.Services.User;

using Models;
using Entities;
using System.Threading.Tasks;
using System;
using Server.Services.Password;
using Microsoft.EntityFrameworkCore;

public class EFUserService(
    ParaLanchesDBContext ctx,
    IPasswordService passService
    ) : IUserService
{
    public async Task<ApplicationUser?> Authenticate(LoginData data)
    {
        var users = 
            from user in ctx.Users
            where user.Name == data.Email || user.Email == data.Email
            select user;

        var foundUser = await users.FirstOrDefaultAsync();

        if (foundUser is null)
            return null;

        if (!passService.Verify(data.Password, foundUser.Password))
            return null;

        return foundUser;
    }

    public async Task<ApplicationUser> CreateUser(AccountData data)
    {
        var user = new ApplicationUser{
            Email = data.Email,
            Name = data.Name,
            Password = passService.Hash(data.Password)
        };

        ctx.Add(user);
        await ctx.SaveChangesAsync();

        return user;
    }

    public async Task<ApplicationUser> CreateUser(AccountData data, Guid invitedByUserId)
    {
        var user = new ApplicationUser{
            Email = data.Email,
            Name = data.Name,
            Password = passService.Hash(data.Password),
            InvitedByUserId = invitedByUserId
        };

        ctx.Add(user);
        await ctx.SaveChangesAsync();

        return user;
    }
}