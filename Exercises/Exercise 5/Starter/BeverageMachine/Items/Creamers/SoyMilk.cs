namespace BeverageMachine.Items.Creamers;

public class SoyMilk : Creamer
{
    public override float? Price => .4F;

    public override void Brew()
    {
        Console.WriteLine($"Adding {nameof(SoyMilk)}");
    }
}
