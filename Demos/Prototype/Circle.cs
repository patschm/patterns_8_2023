namespace Prototype;

internal class Circle: Shape
{
    public int Radius { get; set; }
    public override void Draw()
    {
        Console.WriteLine($"{Color} circle at position ({X}, {Y}) with radius: {Radius}");
    }
    public override Shape Clone()
    {
        return new Circle
        {
            Color = this.Color,
            Radius = this.Radius,
            X = this.X,
            Y = this.Y
        };
    }
}
