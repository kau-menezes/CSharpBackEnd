namespace Server.Services.Token;

using Entities;

public interface ITokenService
{
    string Generate(ApplicationUser user);
}