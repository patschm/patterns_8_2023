namespace AbstractFactory.ArtDeco;

internal class ArtDecoFactory : Factory
{
    public override Chair CreateChair()
    {
        return new ArtDecoChair();
    }

    public override Sofa CreateSofa()
    {
        return new ArtDecoSofa();
    }

    public override Table CreateTable()
    {
        return new ArtDecoTable();
    }
}
