using System.Drawing.Drawing2D;

namespace DrawGraphic;

public class GDIRectangle : Shapes.Rectangle
{
    public Graphics? Graph { get; set; } = null;

    public override void Draw()
    {
        if (Graph == null) return;
        using (Pen pen = new Pen(Color, LineWidth))
        {
            if (IsSelected)
            {
                Graph.FillRectangle(Brushes.Black, Location.X - 5, Location.Y - 5, 10, 10);
                pen.DashStyle = DashStyle.Dash;
            }
            Graph.DrawRectangle(pen, Location.X, Location.Y, Height, Width);
        }
    }
}
