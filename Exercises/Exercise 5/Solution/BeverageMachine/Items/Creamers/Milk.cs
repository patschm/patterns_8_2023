namespace BeverageMachine.Items.Creamers;

public class Milk : Creamer
{
    public Milk(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .3F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Adding {nameof(Milk)}");
    }
}
