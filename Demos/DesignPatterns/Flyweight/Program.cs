namespace Flyweight;

internal class Program
{
    static void Main(string[] args)
    {
        List<Brand> brands = new List<Brand>();
        List<Product> products = new List<Product>();

        var factory = new FlyweightFactory();
        for(var i = 0; i < 1000 ; i++)
        {
            var brand = factory.GetBrand($"Brand {i % 100}", $"https://host.com/brand{i % 100}");
            brands.Add( brand );
            var product = factory.GetProduct($"Brand {i % 100}", $"Type {i%100}", $"https://host.com/brand{i % 100}");
            products.Add( product );    
        }

        Console.ReadLine();
    }
}