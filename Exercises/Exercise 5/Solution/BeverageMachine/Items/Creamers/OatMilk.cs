namespace BeverageMachine.Items.Creamers;

public class OatMilk : Creamer
{
    public OatMilk(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Adding {nameof(OatMilk)}");
    }
}
