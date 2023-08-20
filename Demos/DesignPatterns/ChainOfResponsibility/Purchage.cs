namespace ChainOfResponsibility;

public class Purchase
{
    public string? Item { get; set; }
    public int Number { get; set; }
    public float UnitPrice { get; set; }
    public float TotalPrice { get => UnitPrice * Number; }
}