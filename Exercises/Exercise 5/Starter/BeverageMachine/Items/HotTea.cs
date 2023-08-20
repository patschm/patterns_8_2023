namespace BeverageMachine.Items;

public class HotTea : Beverage
{
    public override float? Price
    {
        get
        {
            float? price = 3F;
            price += Topping != null ? Topping.Price : 0F;
            price += Syrup != null ? Syrup.Price : 0F;
            price += Sweetener != null ? Sweetener.Price : 0F;
            price += Sauce != null ? Sauce.Price : 0F;
            price += Creamer != null ? Creamer.Price : 0F;
            return price;
        }
    }

    public override void Brew()
    {
        Console.WriteLine($"Brewing {nameof(HotTea)}...");
        base.Brew();
    }
}
