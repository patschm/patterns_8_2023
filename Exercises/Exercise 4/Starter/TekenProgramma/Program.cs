using Shapes;

namespace TekenProgramma;

internal class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        do
        {
            Shape fig = SelectFiguur();
            shapes.Add(fig);
            Refresh(shapes);
        }
        while (true);
    }

    static void Refresh(List<Shape> shapes)
    {
        Console.Clear();
        foreach (Shape shape in shapes)
        {
            shape.Draw();
        }
    }

    static Shape SelectFiguur()
    {
        do
        {
            Console.WriteLine("Welk figuur? (rechthoek: r, driehoek: d, cirkel: c)");
            string? fig = Console.ReadLine();
            switch (fig?.Substring(0, 1).ToLower())
            {
                case "r":
                    {
                        return CreateRectangle(200, 100);
                    }
                case "c":
                    {
                        return CreateCircle(200);
                    }
                case "d":
                    {
                        return CreateTriangle(200, 100, 30);
                    }
                default:
                    {
                        Console.WriteLine("Ongeldig figuur");
                        break;
                    }
            }
        }
        while (true);
    }
    static Triangle CreateTriangle(int basis = 200, int hoogte=100, int hoek=30)
    {
        Position pos = RandomPosition();
        return new ConsoleTriangle { Location = pos, Base=basis, Angle = hoek, Heigth = hoogte};
    }
    static Circle CreateCircle(int straal = 100)
    {
        Position pos = RandomPosition();
        return new ConsoleCircle { Location = pos, Radius = straal };
    }
    static Rectangle CreateRectangle(int hoogte = 100, int breedte = 200)
    {
        Position pos = RandomPosition();
        return new ConsoleRectangle { Location = pos, Height = hoogte, Width = breedte };
    }

    private static Position RandomPosition()
    {
        Random random = new Random();
        return new Position { X = random.Next(1, 10) * 50, Y=random.Next(1, 10)*50 };
    }
}