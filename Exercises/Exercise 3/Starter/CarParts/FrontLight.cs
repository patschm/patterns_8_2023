namespace CarParts;

public class FrontLight : Part
{
    public Light Light;
    public FrontLight()
         : base(10, TimeSpan.FromHours(1))
    {
        
    }
}