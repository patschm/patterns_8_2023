namespace FactoryMethod;

public abstract class ModelFactory
{
    public virtual Model Create()
    {
        var model = new Model ();
        return model;
    }
}
