namespace CarParts;

public class Component : Part
{
    public Component(float costPrice, TimeSpan productionTime)
        : base(costPrice, productionTime)
    {
    }

    private readonly List<Component> components = new List<Component>();
    public void Add(Component component) => components.Add(component);

    public override TimeSpan ManufactorTime
    {
        get
        {
            var time = productionTime;
            foreach (var part in components)
            {
                time += part.ManufactorTime;
            }
            return time;
        }
    }
    public override float CostPrice
    {
        get
        {
            var price = costPrice;
            foreach (var part in components)
            {
                price += part.CostPrice;
            }
            return price;
        }
    }
}