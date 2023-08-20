namespace BeverageMachine.Items;

public class HotCoffee : Beverage
{
    public HotCoffee(Beverage? beverage = default) : base(beverage)
    {
    }

    public override float? Price => 3;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Brewing {nameof(HotCoffee)}...");
    }
}
