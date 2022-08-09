namespace PartyUsher.Application.Services.Authentication;

public record AuthenticationResult(

    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);