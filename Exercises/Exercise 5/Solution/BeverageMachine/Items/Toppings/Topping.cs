namespace BeverageMachine.Items.Toppings;

public abstract class Topping : Beverage
{
    protected Topping(Beverage beverage) : base(beverage)
    {
    }
}
