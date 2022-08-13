using PartyUsher.Application;
using PartyUsher.Infrastructure;


var builder = WebApplication.CreateBuilder(args);
{
    builder.Services
        .AddApplication()
        .AddInfrastructure();


    builder.Services.AddControllers(); //use it for configuration and dependency injection 

}


var app = builder.Build();
{

    app.UseHttpsRedirection();
    app.MapControllers();

    app.Run();

}
