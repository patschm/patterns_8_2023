using BeverageMachine.Items.Sauces;

namespace BeverageMachine.Items.Sweeteners;

public class Honey : Sweetener
{
    public override float? Price => .5F;

    public override void Brew()
    {
        Console.WriteLine($"Sweetening with {nameof(Honey)}");
    }
}
