namespace AbstractFactory.ArtDeco;

public class ArtDecoChair : Chair
{
    public override void BuildChair()
    {
        Console.WriteLine("Building an Art Deco Chair");
    }
}