namespace BeverageMachine.Items.Sauces;

public class WhiteChocolate : Sauce
{
    public WhiteChocolate(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .3F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Adding flavour {nameof(WhiteChocolate)}");
    }
}
