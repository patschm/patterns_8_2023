using Shapes;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace DrawGraphic;

public class GDITriangle : Triangle
{
    public Graphics? Graph { get; set; } = null;

    public override void Draw()
    {
        if (Graph == null) return;
        Point[] points = new Point[3];
        points[0] = new Point(Location.X, Location.Y);
        points[1] = new Point(Location.X + Base, Location.Y);
        double hoekRads = Angle * Math.PI / 180;
        int delta = (int)(Heigth / Math.Tan(hoekRads));
        points[2] = new Point(Location.X + delta, Location.Y - Heigth);
        using (Pen pen = new Pen(Color, LineWidth))
        {
            if (IsSelected)
            {
                Graph.FillRectangle(Brushes.Black, Location.X - 5, Location.Y - 5, 10, 10);
                pen.DashStyle = DashStyle.Dash;
            }
            Graph.DrawPolygon(pen, points);
        }
    }
}
