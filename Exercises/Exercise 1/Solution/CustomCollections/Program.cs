using Bogus;

namespace CustomCollections;

internal class Program
{
    static void Main(string[] args)
    {
        var people = CreateCollection(150);

        foreach (var item in people)
            Console.WriteLine(item);
    }

    static SpecialCollection<Person> CreateCollection(int size)
    {
        return new Faker<Person>()
            .RuleFor(p => p.FirstName, f => f.Name.FirstName())
            .RuleFor(p => p.LastName, f => f.Name.LastName())
            .RuleFor(p => p.Age, f => f.Random.Number(0, 125))
            .Generate(size)
            .ToArray();                   
    }
}