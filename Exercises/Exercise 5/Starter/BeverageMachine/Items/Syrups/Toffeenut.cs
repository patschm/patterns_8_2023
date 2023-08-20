namespace BeverageMachine.Items.Syrups;

public class Toffeenut : Syrup
{
    public override float? Price => .4F;

    public override void Brew()
    {
        Console.WriteLine($"Adding {nameof(Toffeenut)} Syrup");
    }
}
