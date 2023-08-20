namespace VisitorNS;

public class Literal : Expression
{
    public Literal(double value)
    {
        Value = value;
    }
    public double Value { get; set; }

    public override double GetValue()
    {
        return Value;
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}
