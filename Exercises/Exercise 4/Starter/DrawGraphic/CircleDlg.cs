using Shapes;

namespace DrawGraphic;

public partial class CircleDlg : ShapeDlg
{
    protected override Shape Generate()
    {
        Circle c = Generate<GDICircle>();
        c.Radius = (int)hRadius.Value;
        return c;
    }
    public CircleDlg()
    {
        InitializeComponent();
    }
}
