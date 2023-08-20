namespace BeverageMachine.Items.Syrups;

public class Toffeenut : Syrup
{
    public Toffeenut(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .4F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Adding {nameof(Toffeenut)} Syrup");
    }
}
