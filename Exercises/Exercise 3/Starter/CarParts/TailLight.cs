namespace CarParts;

public class TailLight : Part
{
    public Light Light;
    public TailLight()
          : base(10, TimeSpan.FromHours(1))
    {
        
    }
}