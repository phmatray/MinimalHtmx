namespace StaticWebApp.Components.Htmx;

public class HxCounterState
{
    public int Value { get; set; } = 0;
    
    public void Increment()
    {
        Value++;
    }
}