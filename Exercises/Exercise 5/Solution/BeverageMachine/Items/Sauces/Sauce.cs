namespace BeverageMachine.Items.Sauces;

public abstract class Sauce : Beverage
{
    protected Sauce(Beverage beverage) : base(beverage)
    {
    }
}
