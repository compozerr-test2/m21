using Carter;
using Microsoft.AspNetCore.Routing;

namespace M21.Endpoints.M21;

public class M21Group : CarterModule
{
    public M21Group() : base("/m21")
    {
        WithTags(nameof(M21));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddM21Route();
    }
}