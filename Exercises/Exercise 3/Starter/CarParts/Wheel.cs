namespace CarParts;

public class Wheel : Part
{
    public DiskBrake Brake;
    public WheelBolt[] WheelBolts = new WheelBolt[5];
    public HubCap Cap;

    public Wheel()
          : base(100, TimeSpan.FromHours(1))
    {
        
    }
}