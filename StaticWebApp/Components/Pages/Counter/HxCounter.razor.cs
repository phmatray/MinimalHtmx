using Carter;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using StaticWebApp.Store;

namespace StaticWebApp.Components.Pages.Counter;

public partial class HxCounter : ComponentBase, ICarterModule
{
    public const string HxCounterEndpoint = "/htmx/counter";
    
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost(HxCounterEndpoint, (AppState state) =>
        {
            state.IncrementCounter();
            return new RazorComponentResult<HxCounter>();
        });
    }
}
