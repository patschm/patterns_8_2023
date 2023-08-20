namespace BeverageMachine.Items;

public class Oleato : Beverage
{
    public Oleato(Beverage? beverage = default) : base(beverage)
    {
    }
    public override float? Price => 3.5F;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Brewing {nameof(Oleato)}...");
    }
}
