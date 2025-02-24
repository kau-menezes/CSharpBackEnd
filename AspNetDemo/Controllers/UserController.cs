using Microsoft.AspNetCore.Mvc;

namespace Server.Controller;

[Route("/user")]
[ApiController]

public class UserController : ControllerBase   
{
    [HttpPost]
    public IActionResult CreateUser()
    {
        throw new NotImplementedException();
    }

    [HttpGet("/invite")]
    public IActionResult GetInvitationURL()
    {
        throw new NotSupportedException();
    }

    [HttpPost("/invitation/{invite}")]
    public IActionResult CreateUserWithInvite()
    {

    }

    [HttpPost("/auth")]
    public IActionResult Login()
    {
        throw new NotImplementedException();
    }

}