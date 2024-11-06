namespace MinimalHtmxProject.Store;

public sealed class AppState
{
    public int Count { get; private set; }
    
    public void IncrementCounter()
    {
        Count++;
    }
    
    public Dictionary<int, Person> Contacts { get; } = new()
    {
        {
            1, new Person
            {
                Id = 1,
                FirstName = "Joe",
                LastName = "Blow",
                Email = "joe@blow.com"
            }
        }
    };
}