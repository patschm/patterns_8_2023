namespace Facade;

internal class Program
{
    static void Main(string[] args)
    {
        var facade = new MathFacade();
        var result = facade.Add(1, 2);
        Console.WriteLine(result);
        result = facade.Subtract(1, 2);
        Console.WriteLine(result);
        result = facade.AddSubtract(5,6,7);
        Console.WriteLine(result);

    }
}