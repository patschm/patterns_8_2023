namespace Media;

public class Amplifier
{
    private int _volume = -1000;
    
    public void Up(int volume)
    {
        _volume+=volume;
        Console.WriteLine($"Volume increased to {_volume}");
    }
    public void Down(int volume)
    {
        _volume -= volume;
        Console.WriteLine($"Volume decreased to {_volume}");
    }
}