namespace CarParts;

public class Car:Part
{
    public Wheel[] Wheels = new Wheel[4];
    public SteeringWheel Steer;
    public FrontDoor[] FrontDoors = new FrontDoor[2];
    public RearDoor[] RearDoors = new RearDoor[2];
    public Engine Engine;
    public TailLight[] TailLights = new TailLight[2];
    public FrontLight[] FrontLights = new FrontLight[2];
    public Trunk Trunk;

    public Car() 
        : base(4000, TimeSpan.FromDays(2))
    {
    }

    
}
