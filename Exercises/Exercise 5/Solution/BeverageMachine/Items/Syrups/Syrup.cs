namespace BeverageMachine.Items.Syrups;

public abstract class Syrup : Beverage
{
    protected Syrup(Beverage beverage) : base(beverage)
    {
    }
}
