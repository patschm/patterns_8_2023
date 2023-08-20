using Bogus;

namespace ChainOfResponsibility;

internal class Program
{
    static void Main(string[] args)
    {
        var chain = new Sales();
        var a2 = new SalesManager();
        var a3 = new SalesDirector();
        var a4 = new President();
        chain.Next(a2);
        a2.Next(a3);
        a3.Next(a4);

        var purcahes = CreatePurchases(100);
        foreach (var purchase in purcahes)
        {
            chain.Approve(purchase);
            Console.WriteLine("=============================================================");
        }
    }

    private static List<Purchase> CreatePurchases(int amount)
    {
        return new Faker<Purchase>()
            .RuleFor(p =>p.Item, f=>f.Commerce.ProductName())
            .RuleFor(p => p.UnitPrice, f => f.Random.Float(10, 1000))
            .RuleFor(p => p.Number, f => f.Random.Int(1, 12))
            .Generate(amount)
            .ToList();
    }
}