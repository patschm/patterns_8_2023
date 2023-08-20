namespace Builder;

internal class BicycleBuilder : IBuilder<Bicycle>
{
    private Bicycle? _bike = null;

    public Bicycle? Result => _bike;

    public string? Color { get; set; }

    public void AddEngine()
    {
        Create();
    }

    public void AddSeats()
    {
        _bike!.HasSeat = true;
    }

    public void AddWheels()
    {
        Create();
        _bike!.Wheels = 2;
    }

    public void Create()
    {
        if (_bike == null )
        {
            _bike = new Bicycle();
            _bike.Color = Color;
        }    
    }
}
