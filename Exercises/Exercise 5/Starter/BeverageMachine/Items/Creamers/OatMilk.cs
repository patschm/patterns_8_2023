namespace BeverageMachine.Items.Creamers;

public class OatMilk : Creamer
{
    public override float? Price => .5F;

    public override void Brew()
    {
        Console.WriteLine($"Adding {nameof(OatMilk)}");
    }
}
