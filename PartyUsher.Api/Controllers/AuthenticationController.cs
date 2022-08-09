using Microsoft.AspNetCore.Mvc;
using PartyUsher.Contracts.Authentication;
using PartyUsher.Application.Services.Authentication;

namespace PartyUsher.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;


    }

    //two endpoints register and login
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        var response = new AuthenticationResponse(
            authResult.Id,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            authResult.Token);

        return Ok(response);

    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {

        return Ok(request);

    }





}