namespace Mediator;

internal class TrafficLight : Component
{
    public TrafficLight(TrafficMediator mediator) : base(mediator)
    {
    }

    public override async Task<bool> CanChangeAsync(TrafficLightState state)
    {
        await Task.Delay(1000);
        SetState(TrafficLightState.Orange, Group);
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
            case TrafficLightState.Orange:
                Console.WriteLine("Traffic Light is Orange");
                break;
            case TrafficLightState.Red:
                Console.WriteLine("Traffic Light is Red");
                break;
            case TrafficLightState.Green:
                Console.WriteLine("Traffic Light is Green");
                break;
            default:
                Console.WriteLine("Traffic Light is defect and blinks");
                break;
        }
    }
    public async void RequestGreen()
    {
        if (LightState == TrafficLightState.Red || LightState == TrafficLightState.Orange)
        {
            await _mediator.RequestStateAsync(Group, TrafficLightState.Green);
        }
    }
}
