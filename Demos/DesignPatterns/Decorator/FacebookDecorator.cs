namespace DecoratorNS;

internal class FacebookDecorator: Decorator
{
    private readonly Message _wrapper;

    public FacebookDecorator(Message wrapper)
    {
        _wrapper = wrapper;
    }

    public override void Send(string text)
    {
        _wrapper.Send($"Sending to Facebook: {text}.");
    }
}
