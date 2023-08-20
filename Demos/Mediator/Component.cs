namespace Mediator;

internal abstract class Component
{
    protected readonly TrafficMediator _mediator;
    protected TrafficLightState LightState = TrafficLightState.Red;

    protected Component(TrafficMediator mediator)
    {
        _mediator = mediator;
        _mediator.StateChange += SetState;
        _mediator.Register(this);
    }

    public string? Group { get; set; }
    public abstract Task<bool> CanChangeAsync(TrafficLightState state);
    public abstract void SetState(TrafficLightState state, string? requestGroup = "");
}
