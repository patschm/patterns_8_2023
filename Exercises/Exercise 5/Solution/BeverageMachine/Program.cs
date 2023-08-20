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
        var t1 = new Caramel(tea);
        var t2 = new DarkCaramel(t1);
        var t3 = new Stevia(t2);
        var t4 = new OatMilk(t3);
        Console.WriteLine(t4.Price);
        t4.Brew();

    }
}