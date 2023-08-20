namespace BeverageMachine.Items.Toppings;

public class CaramelCrunch : Topping
{
    public CaramelCrunch(Beverage beverage) : base(beverage)
    {
    }
    public override float? Price => .5F + _beverage?.Price;

    public override void Brew()
    {
        _beverage?.Brew();
        Console.WriteLine($"Topping of with {nameof(CaramelCrunch)}");
    }
}
