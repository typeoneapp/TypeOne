using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TeamVoting.Modules.TeamGeneration;

public static class TeamGenerationModule
{
    public static IServiceCollection AddTeamGenerationModule(
        this IServiceCollection services, IConfiguration config)
    {
        return services;
    }

    public static IEndpointRouteBuilder MapTeamGenerationEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/teamgeneration").WithTags("TeamGeneration");
        group.MapGet("/ping", () => Results.Ok("TeamGeneration ok"));
        return app;
    }
}

