using Bridge.Animals;

namespace Bridge.Stays;

// Abstraction
public abstract class Stay
{
    // Bridge
    private List<Animal> _animals = new List<Animal>();

    protected abstract bool Check(Animal d);
    public void Contain(Animal d)
    {
        if (Check(d))
        {
            _animals.Add(d);
        }
        else
        {
            Console.WriteLine($"Cannot add {d.GetType().Name} in a {this.GetType().Name}");
        }
    }
    public void Rammel()
    {
        foreach(Animal d in _animals)
        {
            d.MakeNoise(); ;
        }
    }
}
