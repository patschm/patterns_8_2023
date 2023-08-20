namespace CarParts;

public class Car : Component
{
    public Car() 
        : base(4000, TimeSpan.FromDays(2))
    {
    }
}
