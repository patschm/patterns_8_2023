namespace VisitorNS;

public class DisplayVisitor : IVisitor
{
    public void Visit(Literal element)
    {
        Console.Write(element.Value);
    }
    public void Visit(Addition element)
    {
       Console.Write($" + ");
    }
    public void Visit(Subtraction element)
    {
        Console.Write($" - ");
    }
}
