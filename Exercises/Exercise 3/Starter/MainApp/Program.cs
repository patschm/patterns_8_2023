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
            car.FrontDoors[0] = CreateDoor<FrontDoor>();
            car.FrontDoors[1] = CreateDoor<FrontDoor>();
            car.RearDoors[0] = CreateDoor<RearDoor>();
            car.RearDoors[1] = CreateDoor<RearDoor>();
            car.Wheels[0] = CreateWheel();
            car.Wheels[1] = CreateWheel();
            car.Wheels[2] = CreateWheel();
            car.Wheels[3] = CreateWheel();
            car.Steer = CreateSteeringWheel();
            car.Engine =CreateEngine();
            car.Trunk =CreateTrunk();
            car.TailLights[0]=CreateLight<TailLight>();
            car.TailLights[1] = CreateLight<TailLight>();
            car.FrontLights[0] = CreateLight<FrontLight>();
            car.FrontLights[1] = CreateLight<FrontLight>();
            return car;
        }

        private static Trunk CreateTrunk()
        {
            return new Trunk();
        }
        private static Engine CreateEngine()
        {
            var engine = new Engine();
            engine.OilFilter = new OilFilter();
            for(var i = 0; i < 6; i++)
            {
                engine.Cylinders[i]= new Cylinder();
            }
            // And many more
            return engine;
        }
        private static SteeringWheel CreateSteeringWheel()
        {
            return new SteeringWheel();
        }
        private static T CreateLight<T>() where T : Part, new()
        {
            var light = new T();
            if (typeof(T) is FrontLight || typeof(T) is TailLight) 
            {
                (light as FrontLight).Light = new Light();
            }
            
            return light;
        }
        private static Wheel CreateWheel()
        {
            var wheel = new Wheel();
            wheel.Brake = new DiskBrake();
            wheel.WheelBolts[0] = new WheelBolt();
            wheel.WheelBolts[1] = new WheelBolt();
            wheel.WheelBolts[2] = new WheelBolt();
            wheel.WheelBolts[3] = new WheelBolt();
            wheel.WheelBolts[4] = new WheelBolt();
            wheel.Cap = new HubCap();
            return wheel;
        }
        private static T CreateDoor<T>() where T: Part, new() 
        {
            var door = new T();
            if (typeof(T) is FrontDoor || typeof (T) is RearDoor)
            {
                (door as FrontDoor).Handle = new HandleBar();
                (door as FrontDoor).Hinges[0] = new Hinge();
                (door as FrontDoor).Hinges[1] = new Hinge();
            }
            return door;
        }
    }
}