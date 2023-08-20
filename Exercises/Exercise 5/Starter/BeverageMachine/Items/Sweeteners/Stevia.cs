namespace BeverageMachine.Items.Sweeteners;

public class Stevia : Sweetener
{
    public override float? Price => 1.1F;

    public override void Brew()
    {
        Console.WriteLine($"Sweetening with {nameof(Stevia)}");
    }
}
