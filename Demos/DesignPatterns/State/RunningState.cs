namespace State;

internal class RunningState : EngineState
{
    private readonly Engine _engine;

    public RunningState(Engine engine)
    {
        _engine = engine;
    }
    public override void Brake()
    {
        _engine.Brake();
    }
    public override void ClutchDown()
    {
        _engine.SetState(new ClutchInState(_engine));
        _engine.ClutchDown();
    }
    public override void ClutchUp()
    {
        _engine.SetState(new RunningState(_engine));
        _engine.ClutchUp();
    }
    public override void TrottleDown()
    {
        _engine.ThrottleDown();
    }
    public override void TrottleUp()
    {
        _engine.ThrottleUp();
    }
    public override void Stop()
    {
        _engine.SetState(new ShutDownState(_engine));
        _engine.Stop();
    }
}
