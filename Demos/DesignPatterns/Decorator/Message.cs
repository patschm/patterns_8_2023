namespace DecoratorNS;

internal class Message
{
    public virtual void Send(string text)
    {
        Console.WriteLine($"{text}");
    }
}
