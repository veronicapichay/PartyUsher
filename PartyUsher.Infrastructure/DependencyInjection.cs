using Microsoft.Extensions.DependencyInjection;

namespace PartyUsher.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {

        //services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;

    }


}