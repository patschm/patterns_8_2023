namespace Mediator;

internal class Program
{
    static void Main(string[] args)
    {
        var mediator = new TrafficMediator();
        var light1 = new TrafficLight(mediator) { Group = "mainroad" };
        var light2 = new TrafficLight(mediator) { Group = "mainroad" };
        var light3 = new PedestrianTrafficLight(mediator) { Group = "zebra" };
        var light4 = new PedestrianTrafficLight(mediator) { Group = "zebra" };

        do
        {
            Console.WriteLine("Press 1,2,3 or 4 to request green");
            var key = Console.ReadKey();
            switch(key.Key)
            {
                case ConsoleKey.D1:
                    light1.RequestGreen();
                    break;
                case ConsoleKey.D2:
                    light2.RequestGreen();
                    break;
                case ConsoleKey.D3:
                    light3.RequestGreen();
                    break;
                case ConsoleKey.D4:
                    light4.RequestGreen();
                    break;
            }
            Console.WriteLine();
        }
        while (true);
    }
}