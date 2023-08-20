namespace Builder;

internal class Bicycle
{
    public string? Color { get; set; }
    public int Wheels { get; set; }
    public bool HasSeat { get; set; }
    public override string ToString()
    {
        return $"{Color} bicycle with {Wheels} wheels and {(HasSeat ? "with Seat" : "without Engine")}";
    }
}
