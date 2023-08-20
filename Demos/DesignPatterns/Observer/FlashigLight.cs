namespace ObserverNS;

internal class FlashigLight : Observer
{
    public override void Notify(string data)
    {
        Console.WriteLine($"Flash light lit for {data}");
    }
}