using BeverageMachine.Items;
using BeverageMachine.Items.Creamers;
using BeverageMachine.Items.Sauces;
using BeverageMachine.Items.Sweeteners;
using BeverageMachine.Items.Syrups;

namespace BeverageMachine;

internal class Program
{
    static void Main(string[] args)
    {
        var tea = new HotTea();
        tea.Syrup  = new Caramel();
        tea.Sauce = new DarkCaramel();
        tea.Sweetener = new Stevia();
        tea.Creamer = new OatMilk();
        Console.WriteLine(tea.Price);
        tea.Brew();

    }
}