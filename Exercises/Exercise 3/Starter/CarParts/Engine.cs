namespace CarParts;

public class Engine: Part
{
    public OilFilter OilFilter;
    public Cylinder[] Cylinders = new Cylinder[6];
    public Engine()
         : base(6000, TimeSpan.FromDays(14))
    {
        
    }
}
