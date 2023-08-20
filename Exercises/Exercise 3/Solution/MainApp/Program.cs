using CarParts;
using System.Globalization;

namespace MainApp
{
    internal class Program
    {
        static CultureInfo nl = new CultureInfo("nl-NL");

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var car = AssembleCar();
            Console.WriteLine($"{car.ManufactorTime.Days} days to produce");
            Console.WriteLine($"Price: {car.CostPrice.ToString("C", nl)}");
        }

        private static Car AssembleCar()
        {
            var car = new Car();
            car.Add(CreateDoor<FrontDoor>());
            car.Add(CreateDoor<FrontDoor>());
            car.Add(CreateDoor<RearDoor>());
            car.Add(CreateDoor<RearDoor>());
            car.Add(CreateWheel());
            car.Add(CreateWheel());
            car.Add(CreateWheel());
            car.Add(CreateWheel());
            car.Add(CreateSteeringWheel());
            car.Add(CreateEngine());
            car.Add(CreateTrunk());
            car.Add(CreateLight<TailLight>());
            car.Add(CreateLight<FrontLight>());
            return car;
        }

        private static Trunk CreateTrunk()
        {
            return new Trunk();
        }
        private static Engine CreateEngine()
        {
            var engine = new Engine();
            engine.Add(new OilFilter());
            for(var i = 0; i < 6; i++)
            {
                engine.Add(new Cylinder());
            }
            // And many more
            return engine;
        }
        private static SteeringWheel CreateSteeringWheel()
        {
            return new SteeringWheel();
        }
        private static T CreateLight<T>() where T : Component, new()
        {
            var light = new T();
            light.Add(new Light());
            return light;
        }
        private static Wheel CreateWheel()
        {
            var wheel = new Wheel();
            wheel.Add(new DiskBrake()); 
            wheel.Add(new WheelBolt());
            wheel.Add(new WheelBolt());
            wheel.Add(new WheelBolt());
            wheel.Add(new WheelBolt());
            wheel.Add(new WheelBolt());
            wheel.Add(new HubCap());
            return wheel;
        }
        private static T CreateDoor<T>() where T: Component, new() 
        {
            var door = new T();
            door.Add(new HandleBar());
            door.Add(new Hinge());
            door.Add(new Hinge());
            return door;
        }
    }
}