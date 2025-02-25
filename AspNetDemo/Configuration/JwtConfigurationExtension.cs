using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;

namespace Server.Configuration;

public static class JwtConfigurationExtension
{
    /// <summary>
    /// Configure JWT with Authentication
    /// </summary>
    /// <param name="services"></param>
    /// <param name="config"></param>
    /// <returns></returns>
    public static IServiceCollection AddJWTAuthentication(this IServiceCollection services, ConfigurationManager config)
    {
      services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(options => {
            options.TokenValidationParameters = new()
            {
                ValidateIssuer = false, 
                ValidateAudience = false, 
                ValidIssuer = "para_lanches",
                ValidateIssuerSigningKey  = false, 
                ValidateLifetime = true,
                IssuerSigningKey = config.GetJWTSecurityKey()
            };
        });
        services.AddAuthorization();

        return services;
    }
}