namespace Prototype;

// Prototype
internal class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public string? Color { get; set; }

    public virtual void Draw()
    {
        Console.WriteLine($"{Color} shape at position ({X}, {Y})");
    }
    public virtual Shape Clone()
    {
        return new Shape { Color = this.Color, X=this.X, Y=this.Y };
    }
}
