namespace Strategy;

internal class Program
{
    static void Main(string[] args)
    {
        var rnd = new Random();
        var collection = new IntCollection();
        for(var i = 0; i < 22; i++)
        {
            collection.Add(rnd.Next(1, 15));
        }

        ShowCollection(collection);
        //collection.Sort(new BubbleSort());
        collection.Sort(new QuickSort());
        ShowCollection(collection);
    }

    private static void ShowCollection(IntCollection collection)
    {
        foreach (var i in collection)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
    }
}