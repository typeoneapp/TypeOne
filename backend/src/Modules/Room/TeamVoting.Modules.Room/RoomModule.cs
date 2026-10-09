using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TeamVoting.Modules.Room;

public static class RoomModule
{
    public static IServiceCollection AddRoomModule(
        this IServiceCollection services, IConfiguration config)
    {
        return services;
    }

    public static IEndpointRouteBuilder MapRoomEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/api/room").WithTags("Room");
        group.MapGet("/ping", () => Results.Ok("Room ok"));
        return app;
    }
}

