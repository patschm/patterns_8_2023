namespace BeverageMachine.Items.Creamers;

public class SoyMilk : Creamer
{
    public SoyMilk(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .4F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Adding {nameof(SoyMilk)}");
    }
}
