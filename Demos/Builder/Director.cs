namespace Builder;

internal class Director
{
    public Car? CreateCar(IBuilder<Car> builder)
    {
        builder.Color = "Red";
        builder.Create();
        builder.AddWheels();
        builder.AddEngine();
        builder.AddSeats();
        return builder.Result;
    }
    public Bicycle? CreateBicycle(IBuilder<Bicycle> builder)
    {
        builder.Color = "Yellow";
        builder.Create();
        builder.AddWheels();
        builder.AddEngine();
        builder.AddSeats();
        return builder.Result;
    }
}
