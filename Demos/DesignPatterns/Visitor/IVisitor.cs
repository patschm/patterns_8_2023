namespace VisitorNS;

public interface IVisitor
{
    void Visit(Literal element);
    void Visit(Addition element);
    void Visit(Subtraction element);
}