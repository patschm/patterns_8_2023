namespace Singleton;

internal class Program
{
    static void Main(string[] args)
    {
        DataSet.Instance.Increment();
        DataSet.Instance.Increment();
        DataSet.Instance.Increment();
        DataSet.Instance.Increment();
        Console.WriteLine(DataSet.Instance.Counter);
    }
}