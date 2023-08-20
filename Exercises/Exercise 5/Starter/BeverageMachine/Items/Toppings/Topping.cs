namespace BeverageMachine.Items.Toppings;

public abstract class Topping 
{
    public abstract float? Price { get; }
    public abstract void Brew();
}
