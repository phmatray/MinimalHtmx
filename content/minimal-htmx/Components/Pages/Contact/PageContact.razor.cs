using Carter;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MinimalHtmxProject.Store;

namespace MinimalHtmxProject.Components.Pages.Contact;

public partial class PageContact
    : ComponentBase, ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("htmx/contact");
        
        group.MapGet("/{Id:int}", HandleGet);
        group.MapPut("/{Id:int}", HandlePut);
        group.MapGet("/{Id:int}/edit", HandleGetEdit);
    }
    
    // https://andrewlock.net/exploring-the-dotnet-8-preview-form-binding-in-minimal-apis/
    private IResult HandlePut(AppState state, [FromForm] Person person)
    {
        state.Contacts[person.Id] = person;
        return new RazorComponentResult<HxContact>(new { Contact = person });
    }
    
    private IResult HandleGet(AppState state, int id)
    {
        return state.Contacts.TryGetValue(id, out var person)
            ? new RazorComponentResult<HxContact>(new { Contact = person })
            : Results.NotFound();
    }
    
    private IResult HandleGetEdit(AppState state, int id)
    {
        return state.Contacts.TryGetValue(id, out var person)
            ? new RazorComponentResult<HxContactEdit>(new { Contact = person })
            : Results.NotFound();
    }
}