namespace State;

internal class ClutchInState : EngineState
{
    private readonly Engine _engine;

    public ClutchInState(Engine engine)
    {
        _engine = engine;
    }

    public override void Brake()
    {
        _engine.Brake();
    }
    public override void ClutchUp()
    {
        _engine.SetState(new RunningState(_engine));
        _engine.ClutchUp();
    }
    public override void GearDown()
    {
        _engine.GearDown();
    }
    public override void GearUp()
    {
        _engine.GearUp();
    }
    public override void Stop()
    {
        _engine.SetState(new ShutDownState(_engine));   
        _engine.Stop();
    }
}
