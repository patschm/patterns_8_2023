namespace VisitorNS;

public class Subtraction : Expression
{
    public Subtraction(Expression left, Expression right)
    {
        Left = left;
        Right = right;
    }
    public Expression? Left { get; set; }
    public Expression? Right { get; set; }

    public override double GetValue()
    {
        if (Left != null && Right != null)
        {
            return Left.GetValue() - Right.GetValue();
        }
        else if (Left != null) return Left.GetValue();
        else if (Right != null) return -Right.GetValue();
        return 0;
    }
    public override void Accept(IVisitor visitor)
    {
        Left?.Accept(visitor);
        visitor.Visit(this);
        Right?.Accept(visitor);      
    }
}
