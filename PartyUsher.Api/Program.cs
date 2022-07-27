var builder = WebApplication.CreateBuilder(args);
{

    builder.Services.AddControllers(); //use it for configuration and dependency injection 

}


var app = builder.Build();
{

    app.UseHttpsRedirection();
    app.MapControllers();

    app.Run();

}
