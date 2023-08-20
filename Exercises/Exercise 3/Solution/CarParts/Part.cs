namespace CarParts;

public class Part
{
    protected readonly float costPrice;
    protected readonly TimeSpan productionTime;

    public Part(float costPrice, TimeSpan productionTime)
    {
        this.costPrice = costPrice;
        this.productionTime = productionTime;
    }

    public virtual float CostPrice { get => costPrice; }
    public virtual TimeSpan ManufactorTime { get => productionTime; }
}
