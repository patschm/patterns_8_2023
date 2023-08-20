using Bridge.Animals;

namespace Bridge.Stays;

public class Cage: Stay
{
    protected override bool Check(Animal d)
    {
        return d is Cat;
    }
}
