namespace BeverageMachine.Items.Syrups;

public class Hazelnut : Syrup
{
    public override float? Price => .5F;

    public override void Brew()
    {
        Console.WriteLine($"Adding {nameof(Hazelnut)} Syrup");
    }
}
