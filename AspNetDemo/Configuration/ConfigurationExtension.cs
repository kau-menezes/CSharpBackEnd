using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Server.Configuration;

public static class ConfigurationExtension
{
    public static string GetClient(this IConfiguration config)
    {
        var clientURL = config["LocalUrl"]
            ?? throw new Exception("Missing");

        return clientURL;
    }

    public static string GetJWTSecret(this IConfiguration config)
    {
        var clientURL = config["JWTSecret"]
            ?? throw new Exception("Missing");

        return clientURL;
    }

    public static SecurityKey GetJWTSecurityKey(this IConfiguration config)
    {
        var secret = config.GetJWTSecret();
        var keyBytes = Encoding.UTF8.GetBytes(secret);
        var key = new SymmetricSecurityKey(keyBytes);
        return key;
    }
}