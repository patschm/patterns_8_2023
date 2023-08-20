namespace State;

internal class ShutDownState : EngineState
{
    private readonly Engine _engine;

    public ShutDownState(Engine engine)
    {
        _engine = engine;
    }
    public override void Brake()
    {

    }
    public override void ClutchDown()
    {

    }
    public override void ClutchUp()
    {

    }
    public override void GearDown()
    {

    }
    public override void GearUp()
    {

    }
    public override void Start()
    {
        _engine.SetState(new RunningState(_engine));
        _engine.Start();
    }
    public override void TrottleDown()
    {

    }
    public override void TrottleUp()
    {

    }
}
