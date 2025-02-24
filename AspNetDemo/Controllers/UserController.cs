using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Server.Models;
using Server.Services.User;

namespace Server.Controller;

[Route("/user")]
[ApiController]

public class UserController
(
    IUserService service,
    ConfigurationManager config
) : ControllerBase   
{
    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] AccountData data)
    {
        var res = await service.CreateUser(data);
        return Ok(res);
    }

    [HttpGet("/invite")]
    public IActionResult GetInvitationURL()
    {
        var userId = Guid.Empty;
        var localhost = config.GetClient();
        return Ok($"{localhost}/invitation/{userId}");
    }

    [HttpPost("/invitation/{invite}")]
    public async Task<IActionResult> CreateUserWithInvite
    (
        [FromRoute] Guid invite,
        [FromBody] AccountData data
    )
    {
        var res = await service.CreateUser(data, invite);

        return Ok(res);
    }

    [HttpPost("/auth")]
    public IActionResult Login([FromBody] LoginData data)
    {
        var res = service.Authenticate(data);
        return Ok(res);
    }

}