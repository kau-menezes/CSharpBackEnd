
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Server.Configuration;

namespace Server.Services.Token;

public class JWTService
(
    IConfiguration config
) : ITokenService
{
    public string Generate(Entities.ApplicationUser user)
    {
        var jwt = new JwtSecurityToken(
          claims: [
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Name),
          ] ,
          expires: DateTime.UtcNow.AddHours(2),
          signingCredentials: new SigningCredentials(
            config.GetJWTSecurityKey(),
            SecurityAlgorithms.HmacSha256Signature
          )
        );

        var handler = new JwtSecurityTokenHandler();
        return handler.WriteToken(jwt);
    }
}