using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;

namespace Server.Configuration;

public static class ControllerExtension
{
    public static Guid? GetIdClaims(this ClaimsPrincipal claims)
    {
        var claim = claims.FindFirst(ClaimTypes.NameIdentifier);
        if (claim is null)
            return null;

        if (!Guid.TryParse(claim.Value, out var id))
            return null;

        return id;

        
    }
}