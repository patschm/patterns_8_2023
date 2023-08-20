using Shapes;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace DrawGraphic;

public class GDICircle : Circle
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
            Graph.DrawArc(pen, Location.X, Location.Y, Radius, Radius, 0, 360);
        }
    }
}
