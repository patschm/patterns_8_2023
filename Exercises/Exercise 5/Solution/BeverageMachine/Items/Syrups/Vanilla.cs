namespace BeverageMachine.Items.Syrups;

public class Vanilla : Syrup
{
    public Vanilla(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Adding {nameof(Vanilla)} Syrup");
    }
}
