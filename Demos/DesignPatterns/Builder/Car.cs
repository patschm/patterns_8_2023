namespace Builder;

internal class Car
{
    public string? Color { get; set; }
    public int Seats { get; set; }
    public bool HasEngine { get; set; }
    public int Wheels { get; set; }

    public override string ToString()
    {
        return $"{Color} car with {Wheels} wheels, {Seats} seats and {(HasEngine ? "Engine" : "no Engine")}";
    }
}
