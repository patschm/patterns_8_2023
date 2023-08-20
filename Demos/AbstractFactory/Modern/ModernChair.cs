namespace AbstractFactory.Modern;

public class ModernChair : Chair
{
    public override void BuildChair()
    {
        Console.WriteLine("Building a Modern Chair");
    }
}