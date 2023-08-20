
namespace TemplateMethod;

internal class Aquarium : Stay
{
    protected override bool CanContain(Animal animal)
    {
        return animal is Fish;
    }
    protected override void RejectMessage(Animal animal)
    { 
        Console.WriteLine($"{animal.GetType().Name} does not like an Aquarium");
    }

    protected override void CaptureMessage(Animal animal)
    {
        Console.WriteLine($"{animal.GetType().Name} is now in the Aquarium");
    }
}
