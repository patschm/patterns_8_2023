using Shapes;

namespace TekenProgramma;

public class ConsoleRectangle: Rectangle
{
    public override void Draw()
    {
        Console.WriteLine($"Rechthoek met hoogte {Height} en breedte {Width} op positie {Location}");
    }
}
