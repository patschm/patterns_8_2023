namespace BeverageMachine.Items.Sauces;

public abstract class Sauce
{
    public abstract float? Price { get; }
    public abstract void Brew();
}
