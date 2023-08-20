namespace BeverageMachine.Items.Sweeteners;

public class Sugar : Sweetener
{
    public Sugar(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .2F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Sweetening with {nameof(Sugar)}");
    }
}
