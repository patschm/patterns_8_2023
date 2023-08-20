namespace Composite;

internal class Composite : Component
{
    private List<Component> _components = new List<Component>();

    public void Add(Component component)
    { 
        _components.Add(component); 
    }

    public override void Show()
    {
        Console.WriteLine("This is a NODE:");
        foreach(var component in _components)
        {
            component.Show();
        }
    }
}
