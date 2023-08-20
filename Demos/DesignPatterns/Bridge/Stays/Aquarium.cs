using Bridge.Animals;

namespace Bridge.Stays;

public class Aquarium: Stay
{
    protected override bool Check(Animal d)
    {
        return d is Fish;
    }

}
