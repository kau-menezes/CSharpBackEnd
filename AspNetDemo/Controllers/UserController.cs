using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Configuration;
using Server.Models;
using Server.Services.Token;
using Server.Services.User;

namespace Server.Controller;

[Route("user")]
[ApiController]

public class UserController
(
    IUserService service,
    ITokenService jwtService,
    ConfigurationManager config
) : ControllerBase   
{
    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] AccountData data)
    {
        var res = await service.CreateUser(data);
        return Ok(res);
    }

    [HttpGet("invite")]
    public IActionResult GetInvitationURL()
    {

        var userId = User.GetIdClaims();
        if (userId is null)
            return Unauthorized();

        var localhost = config.GetClient();
        return Ok($"{localhost}/invitation/{userId}");
    }

    [HttpPost("invitation/{invite}")]
    public async Task<IActionResult> CreateUserWithInvite
    (
        [FromRoute] Guid invite,
        [FromBody] AccountData data
    )
    {
        var res = await service.CreateUser(data, invite);

        return Ok(res);
    }

    [HttpPost("auth")]
    public async Task<IActionResult> Login([FromBody] LoginData data)
    {
        var res = await service.Authenticate(data);

        if (res is null)
            return Unauthorized();
        
        var jwt = jwtService.Generate(res);

        return Ok(new { jwt });
    }

}