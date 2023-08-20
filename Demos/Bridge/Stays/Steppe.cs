using Bridge.Animals;

namespace Bridge.Stays;

public class Steppe: Stay
{
    protected override bool Check(Animal d)
    {
        return d is Grazer;
    }
}
