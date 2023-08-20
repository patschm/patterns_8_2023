namespace Media;

public class MusicPlayer: IMediaPlayer
{
    private readonly PaymentService _paymentService;

    public string? Song { get; set; }

    public MusicPlayer(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void Play(string jwtToken, string user, string song)
    {
        Song = song;
        if (_paymentService.CheckAccess(jwtToken, user, Song))
        {
            Console.WriteLine($"Now playing Song {Song}");
        }
        else
        {
            Console.WriteLine("No access. Pay first!");
        }
    }
    public void Pause()
    {
        Console.WriteLine($"Paused Song {Song}");
    }
    public void Stop()
    {
        Console.WriteLine($"Stop playing Song {Song}");
    }
}