
namespace BeverageMachine.Items.Syrups;

public class Caramel : Syrup
{
    public override float? Price => .5F;

    public override void Brew()
    {
        Console.WriteLine($"Adding {nameof(Caramel)} Syrup");
    }
}
