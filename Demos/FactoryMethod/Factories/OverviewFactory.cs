using FactoryMethod.Models;

namespace FactoryMethod.Factories;

public class OverviewFactory: ModelFactory
{
    public override Model Create()
    {
        var model = new OverviewModel();
        model.Title = "Overview";
        model.OverviewThings = new List<string> { "One", "Two", "Three" };
        return model;

    }
}
