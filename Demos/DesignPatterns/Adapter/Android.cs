namespace Adapter;

internal class Android : IMicroUSB
{
    public void ConnectMicroUSB()
    {
        Console.WriteLine("Micro USB connected!");
    }

    public void Recharge()
    {
        Console.WriteLine("Recharge started...");
    }
}
