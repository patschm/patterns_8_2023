namespace Proxy;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to start...");
        Console.ReadLine();
        TestProxy();
        Console.ReadLine();
    }

    private static async void TestProxy()
    {
        var proxy = new MathServiceProxy("https://localhost:8001/math/");
        var r1 = await proxy.AddAsync(1, 2);
        Console.WriteLine(r1);
        var r2 = await proxy.SubtractAsync(8, 4);
        Console.WriteLine(r2);
    }
}