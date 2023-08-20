using Bridge.Animals;
using Bridge.Stays;

namespace Bridge;

internal class Program
{
    static void Main(string[] args)
    {
        var zoo = CreateZoo();

        zoo.Open();
    }

    private static Zoo CreateZoo()
    {
        var zoo = new Zoo();
        var cage = new Cage();
        cage.Contain(new Lion());
        cage.Contain(new Tiger());
        zoo.Add(cage);
        
        var steppe = new Steppe();
        steppe.Contain(new Wildebeest());   
        steppe.Contain(new Zebra());
        zoo.Add(steppe);

        var aqua = new Aquarium();
        aqua.Contain(new ElectricEel());
        aqua.Contain(new ClownsFish());
        aqua.Contain(new Tiger());
        zoo.Add(aqua);

        return zoo;

    }
}