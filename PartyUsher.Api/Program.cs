using PartyUsher.Application.Services.Authentication;
var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
    builder.Services.AddControllers(); //use it for configuration and dependency injection 

}


var app = builder.Build();
{

    app.UseHttpsRedirection();
    app.MapControllers();

    app.Run();

}
