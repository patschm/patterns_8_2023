namespace VisitorNS;

internal class Program
{
    static void Main(string[] args)
    {
        var a1 = new Addition(new Literal(1), new Literal(2));
        var s1 = new Subtraction(new Literal(3), new Literal(4));
        var a2 = new Addition(a1, s1);
        var final = new Addition(a2, new Literal(5));

        var visitor = new DisplayVisitor();
        final.Accept(visitor);
        Console.WriteLine($" = {final.GetValue()}");
    }
}