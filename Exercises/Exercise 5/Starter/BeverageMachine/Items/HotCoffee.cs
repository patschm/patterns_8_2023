using BeverageMachine.Items.Creamers;
using BeverageMachine.Items.Sauces;
using BeverageMachine.Items.Sweeteners;
using BeverageMachine.Items.Syrups;
using BeverageMachine.Items.Toppings;

namespace BeverageMachine.Items;

public class HotCoffee : Beverage
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
        Console.WriteLine($"Brewing {nameof(HotCoffee)}...");
        base.Brew();
    }
}
