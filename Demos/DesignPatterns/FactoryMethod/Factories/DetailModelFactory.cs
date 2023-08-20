using FactoryMethod.Models;

namespace FactoryMethod.Factories;

public class DetailModelFactory: ModelFactory
{
    public override Model Create()
    {
        var model = new DetailModel();
        model!.Title = "Detail";
        model.DetailThings = "Detailed information";
       return model;
    }
}
