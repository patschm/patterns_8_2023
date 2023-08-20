namespace Prototype;

internal class Rectangle: Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override void Draw()
    {
        Console.WriteLine($"{Color} rectangle at position ({X}, {Y}) with height: {Height} and width: {Width}");
    }
    public override Shape Clone()
    {
        return new Rectangle { 
            Color = this.Color, 
            Height=this.Height, 
            Width=this.Width, 
            X=this.X, 
            Y=this.Y };
    }
}
