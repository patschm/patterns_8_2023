
using Shapes;
using System.IO;

namespace TekenProgramma;

internal class ConsoleDevice : IDevice
{
    public void DrawCircle(Circle c)
    {
        Console.WriteLine($"Cirkel met straal {c.Radius} op positie {c.Location}");
    }

    public void DrawRectangle(Rectangle r)
    {
        Console.WriteLine($"Rechthoek met hoogte {r.Height} en breedte {r.Width} op positie {r.Location}");
    }

    public void DrawTriangle(Triangle t)
    {
        Console.WriteLine($"Driehoek met basis {t.Base}, hoogte {t.Heigth} en hoek {t.Angle} op positie {t.Location}");
    }
}
