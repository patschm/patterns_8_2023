using Shapes;

namespace TekenProgramma;

public class ConsoleTriangle: Triangle
{
    public override void Draw()
    {
        Console.WriteLine($"Driehoek met basis {Base}, hoogte {Heigth} en hoek {Angle} op positie {Location}");
    }
}
