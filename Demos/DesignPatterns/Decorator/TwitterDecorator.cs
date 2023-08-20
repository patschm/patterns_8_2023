using static System.Net.Mime.MediaTypeNames;

namespace DecoratorNS;

internal class TwitterDecorator : Decorator
{
    private readonly Message _wrapper;

    public TwitterDecorator(Message wrapper)
    {
        _wrapper = wrapper;
    }

    public override void Send(string text)
    {
        _wrapper.Send($"Sending to Twitter: {text}.");
    }
}
