using Shapes;

namespace TekenProgramma;

public class ConsoleCircle: Circle
{
    public override void Draw()
    {
        Console.WriteLine($"Cirkel met straal {Radius} op positie {Location}");
    }
}
