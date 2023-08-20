namespace State;

internal class EngineState
{
    public virtual void Start() { }
    public virtual void Stop() { }
    public virtual void GearUp() { }
    public virtual void GearDown() { }
    public virtual void TrottleUp() { }
    public virtual void TrottleDown() { }
    public virtual void Brake() { }
    public virtual void ClutchDown() { }
    public virtual void ClutchUp() { }
}
