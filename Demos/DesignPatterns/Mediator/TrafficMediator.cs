namespace Mediator;

delegate void StateChange(TrafficLightState state, string? requestGroup = "");

internal class TrafficMediator
{
    private readonly List<Component> _components = new List<Component>();
    public event StateChange? StateChange;

    public async Task RequestStateAsync(string? requestGroup, TrafficLightState state)
    {
        var tasks = new List<Task<bool>>();
        foreach (var component in _components)
        {
            if (component.Group != requestGroup)
            {
                tasks.Add(component.CanChangeAsync(state));
            }
        }
        await Task.WhenAll(tasks);  
        StateChange?.Invoke(state, requestGroup);
    }
    public void Register(Component component)
    {
        _components.Add(component);
    }
}
