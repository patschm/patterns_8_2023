namespace BeverageMachine.Items.Sweeteners;

public abstract class Sweetener
{
    public abstract float? Price { get; }
    public abstract void Brew();
}
