using FactoryMethod.Factories;
using FactoryMethod.Models;
using Microsoft.VisualBasic;

namespace FactoryMethod;

internal class Program
{
    static void Main(string[] args)
    {
        var overviewFactory = new OverviewFactory();
        var detailFactory = new DetailModelFactory();

        var model1 = overviewFactory.Create() as OverviewModel;
        var model2 = detailFactory.Create() as DetailModel;

        Console.WriteLine(model1?.Title);
        foreach(var item in model1?.OverviewThings!)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("=======================");
        Console.WriteLine(model2?.Title);
        Console.WriteLine(model2?.DetailThings);


    }
}