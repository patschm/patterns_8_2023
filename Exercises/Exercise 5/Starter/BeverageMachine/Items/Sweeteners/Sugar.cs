namespace BeverageMachine.Items.Sweeteners;

public class Sugar : Sweetener
{
    public override float? Price => .2F;

    public override void Brew()
    {
        Console.WriteLine($"Sweetening with {nameof(Sugar)}");
    }
}
