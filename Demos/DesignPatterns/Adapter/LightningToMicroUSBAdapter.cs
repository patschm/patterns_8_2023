namespace Adapter;

internal class LightningToMicroUSBAdapter : IMicroUSB
{
    private readonly ILightning _lightning;

    public LightningToMicroUSBAdapter(ILightning lightning)
    {
        _lightning = lightning;
    }

    public void ConnectMicroUSB()
    {
        _lightning.ConnectLightning();
    }

    public void Recharge()
    {
        _lightning.Recharge();
    }
}
