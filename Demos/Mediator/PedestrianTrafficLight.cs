namespace Mediator;

internal class PedestrianTrafficLight : Component
{
    public PedestrianTrafficLight(TrafficMediator mediator) : base(mediator)
    {
    }

    public override async Task<bool> CanChangeAsync(TrafficLightState state)
    {
        await Task.Delay(1000);
        SetState(TrafficLightState.Blink, Group);
        await Task.Delay(5000);
        SetState(TrafficLightState.Red, Group);
        LightState = TrafficLightState.Red;
        return true;
    }

    public override void SetState(TrafficLightState state, string? requestGroup = "")
    {
        if (requestGroup == null || requestGroup != Group) return;
        switch (state)
        {
            case TrafficLightState.Blink:
                Console.WriteLine("Green Pedestrian Trafficlight starts blinking...");
                break;
            case TrafficLightState.Red:
                Console.WriteLine("Pedestrian Trafficlight is Red");
                break;
            case TrafficLightState.Green:
                Console.WriteLine("Pedestrian Trafficlight is Green");
                break;
        }
    }
    public async void RequestGreen()
    {
        if (LightState == TrafficLightState.Red)
        {
            await _mediator.RequestStateAsync(Group, TrafficLightState.Green);
        }
    }
}
