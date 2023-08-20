using Shapes;
namespace DrawGraphic;

public partial class TriangleDlg : ShapeDlg
{ 
    protected override Shape Generate()
    {
        GDITriangle c = Generate<GDITriangle>();
        c.Base = (int)hBase.Value;
        c.Heigth = (int)hHeight.Value;
        c.Angle = (int)hAngle.Value;
        return c;
    }
    public TriangleDlg()
    {
        InitializeComponent();
    }


}
