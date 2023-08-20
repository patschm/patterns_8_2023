using Shapes;

namespace DrawGraphic;

public partial class RectangleDlg : ShapeDlg
{
    protected override Shape Generate()
    {
        GDIRectangle c = Generate<GDIRectangle>();
        c.Height = (int)hWidth.Value;
        c.Width = (int)hHeight.Value;
        return c;
    }
    public RectangleDlg()
    {
        InitializeComponent();
    }
}
