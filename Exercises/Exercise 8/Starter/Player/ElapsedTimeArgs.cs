namespace Player;

public class ElapsedTimeArgs: EventArgs
{
    public TimeSpan Time { get; set; } = TimeSpan.Zero;
}
