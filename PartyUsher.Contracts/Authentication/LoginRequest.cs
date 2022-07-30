namespace PartyUsher.Contracts.Authentication;

public record LoginRequest(
    string FirstName,
    string LastName,
    string Email,
    string Password);
