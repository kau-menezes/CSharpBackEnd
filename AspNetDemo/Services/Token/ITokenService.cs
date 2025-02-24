namespace Server.Services.Token;

using Entities;

public interface ITokenService
{
    string Generate(User user);
}