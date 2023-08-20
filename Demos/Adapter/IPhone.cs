namespace Adapter;

internal class IPhone : ILightning
{
    public void ConnectLightning()
    {
        Console.WriteLine("Lightning connected!");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharge started...");
    }
}
