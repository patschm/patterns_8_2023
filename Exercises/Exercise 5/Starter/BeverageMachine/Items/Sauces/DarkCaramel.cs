namespace BeverageMachine.Items.Sauces;

public class DarkCaramel : Sauce
{
    public override float? Price => .3F;

    public override void Brew()
    {
        Console.WriteLine($"Adding flavour {nameof(DarkCaramel)}");
    }
}
