namespace State;

internal class Engine
{
    private int _gear = 0;
    private int _speed = 0;
    private EngineState _state;

    public Engine()
    {
        _state = new ShutDownState(this);
    }
    public void StartAction()
    {
        _state.Start();
    }
    public void StopAction()
    {
        _state.Stop();
    }
    public void BrakeAction()
    {
        _state.Brake();
    }
    public void ThrottleUpAction()
    {
        _state.TrottleUp();
    }
    public void ThrottleDownAction()
    {
       _state.TrottleDown();
    }
    public void GearUpAction()
    {
        _state.GearUp();
    }
    public void GearDownAction()
    {
        _state.GearDown();
    }
    public void ClutchUpAction()
    {
        _state.ClutchUp();
    }
    public void ClutchDownAction()
    {
        _state.ClutchDown();
    }
    internal void SetState(EngineState state)
    {
        _state = state;
    }
    internal void Start()
    {
        Console.WriteLine("Engine is started");
    }
    internal void Stop()
    {
        Console.WriteLine("Engine is stopped");
    }
    internal void Brake()
    {
        Console.WriteLine("Hitting the brakes");
    }
    internal void ThrottleDown()
    {
        if (_gear <= 0)
        {
            Console.WriteLine("Engine is not in a gear");
            return;
        }
        _speed += 10;
        Console.WriteLine($"Accelerating to {_speed}");
    }
    internal void ThrottleUp()
    {
        if (_gear <= 0)
        {
            _gear = 0;
            return;
        }
        _speed -= 10;
        Console.WriteLine($"Decelerating to {_speed}");
    }
    internal void GearUp()
    {
        Console.WriteLine($"Gearing Up to {++_gear}");
    }
    internal void GearDown()
    {
        Console.WriteLine($"Gearing Down to {--_gear}");
    }
    internal void ClutchUp()
    {
        Console.WriteLine($"Clutch out");
    }
    internal void ClutchDown()
    {
        Console.WriteLine($"Clutch in");
    }
}
