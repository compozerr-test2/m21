using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using M21.Services;

namespace M21.Endpoints.M21;

public static class M21Route
{
    public static RouteHandlerBuilder AddM21Route(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IM21Service m21Service) => new GetM21Response($"Hello, {m21Service.GetObfuscatedName(name)}!"));
    }
}