namespace Iterator;

internal class Program
{
    static void Main(string[] args)
    {
        var col = new WeirdCollection<int>();
        col.Add(1);
        col.Add(2);
        col.Add(3);
        col.Add(4);
        col.Add(5);
        col.Add(6);
        col.Add(7);
        var iterator = col.GetIterator();
        while(iterator.Next()) 
        {
            Console.WriteLine(iterator.CurrentValue);
        }


    }
}