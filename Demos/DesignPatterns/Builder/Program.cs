namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var carBuilder = new CarBuilder();
            var bikeBuilder = new BicycleBuilder();
            var director = new Director();
            var bike = director.CreateBicycle(bikeBuilder);
            var car = director.CreateCar(carBuilder);

            Console.WriteLine(bike);
            Console.WriteLine(car);
        }
    }
}