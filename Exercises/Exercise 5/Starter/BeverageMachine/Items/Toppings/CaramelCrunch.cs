namespace BeverageMachine.Items.Toppings;

public class CaramelCrunch : Topping
{
    public override float? Price => .5F;

    public override void Brew()
    {
        Console.WriteLine($"Topping of with {nameof(CaramelCrunch)}");
    }
}
