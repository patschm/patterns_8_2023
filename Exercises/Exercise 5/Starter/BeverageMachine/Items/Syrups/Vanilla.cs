namespace BeverageMachine.Items.Syrups;

public class Vanilla : Syrup
{
    public override float? Price => .5F;

    public override void Brew()
    {
        Console.WriteLine($"Adding {nameof(Vanilla)} Syrup");
    }
}
