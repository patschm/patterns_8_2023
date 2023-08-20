namespace BeverageMachine.Items.Syrups;

public abstract class Syrup
{
    public abstract float? Price { get; }
    public abstract void Brew();
}
