using Microsoft.AspNetCore.Mvc;
using PartyUsher.Contracts.Authentication;

namespace PartyUsher.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    //two endpoints register and login
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {

        return Ok(request);

    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {

        return Ok(request);

    }





}