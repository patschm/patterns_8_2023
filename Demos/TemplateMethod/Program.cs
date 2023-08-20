namespace TemplateMethod;

internal class Program
{
    static void Main(string[] args)
    {
        var stay = new Aquarium();
        stay.Contain(new Eel());
        stay.Contain(new Herring());
        stay.Contain(new Lion());
    }
}