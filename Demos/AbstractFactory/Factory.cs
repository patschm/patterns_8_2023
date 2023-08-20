namespace AbstractFactory;

internal abstract class Factory
{
    public abstract Chair CreateChair();
    public abstract Table CreateTable();
    public abstract Sofa CreateSofa();

}
