namespace Builder;

internal class CarBuilder : IBuilder<Car>
{
    private Car? _car = null;

    public Car? Result => _car;

    public string? Color { get ; set; }

    public void AddEngine()
    {
        Create();
        _car!.HasEngine = true;
    }

    public void AddSeats()
    {
        _car!.Seats = 4;
    }

    public void AddWheels()
    {
        Create();
        _car!.Wheels = 4;
    }

    public void Create()
    {
        if (_car == null )
        {
            _car = new Car();
            _car.Color = Color;
        }    
    }
}
