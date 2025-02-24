namespace Server.Services.User;

using Entities;
using Models;

public interface IUserService
{
    Task<User> CreateUser(AccountData data);
    Task<User> CreateUser(AccountData data, Guid invitedByUserId);

    Task<User?> Authenticate(LoginData data);
}