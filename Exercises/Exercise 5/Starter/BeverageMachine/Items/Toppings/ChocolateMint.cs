using BeverageMachine.Items.Syrups;

namespace BeverageMachine.Items.Toppings;

public class ChocolateMint : Topping
{
    public override float? Price => .5F;

    public override void Brew()
    {
        Console.WriteLine($"Topping of with {nameof(ChocolateMint)}");
    }
}
