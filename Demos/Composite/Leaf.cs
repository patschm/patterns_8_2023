namespace Composite;

internal class Leaf : Component
{
    public override void Show()
    {
        Console.WriteLine("\tThis is a LEAF");
    }
}
