namespace BeverageMachine.Items.Creamers;

public abstract class Creamer
{
    public abstract float? Price { get; }
    public abstract void Brew();
}
