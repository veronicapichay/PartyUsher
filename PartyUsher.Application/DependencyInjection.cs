using Microsoft.Extensions.DependencyInjection;
using PartyUsher.Application.Services.Authentication;

namespace PartyUsher.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {

        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;

    }


}