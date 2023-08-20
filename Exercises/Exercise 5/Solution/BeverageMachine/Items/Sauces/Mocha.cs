namespace BeverageMachine.Items.Sauces;

public class Mocha : Sauce
{
    public Mocha(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .3F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Adding flavour {nameof(Mocha)}");
    }
}
