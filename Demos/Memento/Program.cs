namespace Memento;

internal class Program
{
    static void Main(string[] args)
    {
        var hyper = new HyperV();
        var vm = hyper.StartVM();
        for (int i = 0; i < 10; i++) 
        {
            vm.DoSomeWork();
            Console.WriteLine("Press enter to do some work");
            Console.ReadLine();
            if (i % 2 == 0) 
                hyper.CreateSnapShot();
        }
        hyper.ShowSnapShots();
        Console.WriteLine("Select Snapshot:");
        int.TryParse(Console.ReadLine(), out int nr);
        var rvm = hyper.RestoreSnapShot(nr);
        Console.WriteLine(rvm);

    }
}