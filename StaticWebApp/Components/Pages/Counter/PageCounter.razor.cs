using Carter;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using StaticWebApp.Store;

namespace StaticWebApp.Components.Pages.Counter;

public partial class PageCounter
    : ComponentBase, ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("htmx/counter", HandlePost);
    }

    private static IResult HandlePost(AppState state)
    {
        state.IncrementCounter();
        return new RazorComponentResult<HxCounter>(new { state.Count });
    }
}