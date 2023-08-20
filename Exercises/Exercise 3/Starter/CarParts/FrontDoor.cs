namespace CarParts;

public class FrontDoor : Part
{
    public HandleBar Handle;
    public Hinge[] Hinges = new Hinge[2];

    public FrontDoor()
         : base(400, TimeSpan.FromHours(4))
    {
        
    }
}