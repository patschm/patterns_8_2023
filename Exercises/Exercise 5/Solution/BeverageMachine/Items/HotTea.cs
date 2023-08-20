namespace BeverageMachine.Items;

public class HotTea : Beverage
{

    public HotTea(Beverage? beverage = default) : base(beverage)
    {
    }
    public override float? Price => 3;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Brewing {nameof(HotTea)}...");
    }
}
