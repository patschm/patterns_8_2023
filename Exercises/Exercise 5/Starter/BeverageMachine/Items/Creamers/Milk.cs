namespace BeverageMachine.Items.Creamers;

public class Milk : Creamer
{
    public override float? Price => .3F;

    public override void Brew()
    {
        Console.WriteLine($"Adding {nameof(Milk)}");
    }
}
