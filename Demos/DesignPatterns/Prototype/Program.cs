namespace Prototype;

internal class Program
{
    static void Main(string[] args)
    {
        var circle = new Circle() { Color="Red", Radius=100, X=10, Y=10 };
        var rectangle = new Rectangle() { X=10,Y=10 , Color="Green", Height=100, Width=200 };

        var circle2 = circle.Clone();
        circle2.Color = "Blue";
        var rectangle2 = rectangle.Clone();
        rectangle2.Color = "Yellow";

        circle.Draw();
        circle2.Draw();
        rectangle.Draw();
        rectangle2.Draw();  
        
    }
}