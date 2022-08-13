using PartyUsher.Application.Common.Interfaces.Authentication


namespace PartyUsher.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    //inject the defined token generator interface to the constructor
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {

        _jwtTokenGenerator = jwtTokenGenerator;


    }


    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {

        //Checks if user is already in db

        //Create user unique id if it doesn't exist yet

        //Create token
        var token = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName); //introduce a local variable guid.newguid 


        return new AuthenticationResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            "token");

    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "firstName",
            "lastName",
            email,
            "token");


    }



}