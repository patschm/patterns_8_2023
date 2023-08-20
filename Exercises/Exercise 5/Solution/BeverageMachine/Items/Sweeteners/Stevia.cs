namespace BeverageMachine.Items.Sweeteners;

public class Stevia : Sweetener
{
    public Stevia(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => 1.1F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Sweetening with {nameof(Stevia)}");
    }
}
