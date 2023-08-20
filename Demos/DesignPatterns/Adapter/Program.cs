namespace Adapter;

internal class Program
{
    static void Main(string[] args)
    {
        var phone1 = new IPhone();
        var phone2 = new Android();

        Recharge(phone2 );
        // Recharge(phone1); // Doesn't work
        var adapter= new LightningToMicroUSBAdapter(phone1);
        Recharge(adapter );
    }

    public static void Recharge(IMicroUSB phone)
    {
        phone.ConnectMicroUSB();
        phone.Recharge();
    }
}