namespace StaticWebApp.Components;

public interface IHasEndpoints
{
    static abstract void MapEndpoints(WebApplication app);
}