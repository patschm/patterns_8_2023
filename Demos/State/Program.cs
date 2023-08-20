namespace State;

internal class Program
{
    static void Main(string[] args)
    {
        var engine = new Engine();
        engine.ThrottleDownAction(); // Nothing should happen
        engine.StartAction();
        engine.ThrottleUpAction(); // Nothing should happen
        engine.ClutchDownAction();
        engine.GearUpAction();
        engine.ThrottleDownAction(); // Nothing should happen
        engine.ClutchUpAction();
        engine.ThrottleDownAction();
        engine.ThrottleUpAction();
        engine.StopAction();
    }
}