namespace Media;

public class PodcastPlayer : IMediaPlayer
{
    private readonly PaymentService _paymentService;
    public string? Title { get; set; }

    public PodcastPlayer(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void Play(string jwtToken, string user, string title)
    {
        Title = title;
        if (_paymentService.CheckAccess(jwtToken, user, Title))
        {
            Console.WriteLine($"Now playing Podcast {Title}");
        }
        else
        {
            Console.WriteLine("No access. Pay first!");
        }
    }
    public void Pause()
    {
        Console.WriteLine($"Paused Podcast {Title}");
    }
    public void Stop()
    {
        Console.WriteLine($"Stop playing Podcast {Title}");
    }

}