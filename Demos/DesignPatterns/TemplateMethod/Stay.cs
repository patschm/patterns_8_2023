namespace TemplateMethod;

internal abstract class Stay
{
    private List<Animal> _animals = new List<Animal>();

    public void Contain(Animal animal)
    {
        if (CanContain(animal))
        {
            _animals.Add(animal);
            CaptureMessage(animal);
        }
        else
        {
            RejectMessage(animal);
            
        }
    }

    protected virtual void RejectMessage(Animal animal)
    {
        Console.WriteLine($"Stay cannot contain a {animal.GetType().Name}");
    }

    protected virtual void CaptureMessage(Animal animal)
    {
        Console.WriteLine($"{animal.GetType().Name} is in the Stay");
    }

    protected abstract bool CanContain(Animal animal);
}
