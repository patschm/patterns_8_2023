namespace BeverageMachine.Items.Sauces;

public class Mocha : Sauce
{
    public override float? Price => .3F;

    public override void Brew()
    {
        Console.WriteLine($"Adding flavour {nameof(Mocha)}");
    }
}
