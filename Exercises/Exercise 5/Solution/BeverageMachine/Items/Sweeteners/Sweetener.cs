namespace BeverageMachine.Items.Sweeteners;

public abstract class Sweetener : Beverage
{
    protected Sweetener(Beverage beverage) : base(beverage)
    {
    }
}
