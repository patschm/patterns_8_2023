namespace VisitorNS;

public abstract class Expression
{
    public abstract void Accept(IVisitor visitor);
    public abstract double GetValue();
}
