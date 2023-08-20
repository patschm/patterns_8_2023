namespace AbstractFactory.Modern;

internal class ModernFactory : Factory
{
    public override Chair CreateChair()
    {
        return new ModernChair();
    }

    public override Sofa CreateSofa()
    {
        return new ModernSofa();
    }

    public override Table CreateTable()
    {
        return new ModernTable();
    }
}
