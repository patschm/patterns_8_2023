namespace Media;

public class MoviePlayer: IMediaPlayer
{
    private readonly PaymentService _paymentService;

    public string? Title { get; set; }
    public MoviePlayer(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void Play(string jwtToken, string user, string title)
    {
        Title = title;
        if (_paymentService.CheckAccess(jwtToken, user, Title))
        {
            Console.WriteLine($"Now playing Movie {Title}");
        }
        else
        {
            Console.WriteLine("No access. Pay first!");
        }
    }
    public void Pause()
    {
        Console.WriteLine($"Paused Movie {Title}");
    }
    public void Stop()
    {
        Console.WriteLine($"Stop playing Movie {Title}");
    }
}