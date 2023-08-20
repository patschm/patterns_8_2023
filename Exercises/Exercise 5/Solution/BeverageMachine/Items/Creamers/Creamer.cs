namespace BeverageMachine.Items.Creamers;

public abstract class Creamer : Beverage
{
    protected Creamer(Beverage beverage) : base(beverage)
    {
    }
}
