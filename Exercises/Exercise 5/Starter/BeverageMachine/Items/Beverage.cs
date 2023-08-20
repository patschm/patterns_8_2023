using BeverageMachine.Items.Creamers;
using BeverageMachine.Items.Sauces;
using BeverageMachine.Items.Sweeteners;
using BeverageMachine.Items.Syrups;
using BeverageMachine.Items.Toppings;

namespace BeverageMachine.Items;

public abstract class Beverage
{
    public Topping? Topping { get; set; }
    public Syrup? Syrup { get; set; }
    public Sweetener? Sweetener { get; set; }
    public Sauce? Sauce { get; set; }
    public Creamer? Creamer { get; set; }

    public abstract float? Price { get; }
    public virtual void Brew()
    {
        Topping?.Brew();
        Syrup?.Brew();
        Sweetener?.Brew();
        Sauce?.Brew();
        Creamer?.Brew();
    }
}
