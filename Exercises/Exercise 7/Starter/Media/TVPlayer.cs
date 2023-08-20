namespace Media;

public class TVPlayer: IMediaPlayer
{
    private readonly PaymentService _paymentService;
    private string? Name;

    public TVPlayer(PaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void Play(string jwtToken, string user, string name)
    {
        Name = name;
        if (_paymentService.CheckAccess(jwtToken, user, Name))
        {
            Console.WriteLine($"Now playing TV program{Name}");
        }
        else
        {
            Console.WriteLine("No access. Pay first!");
        }
    }
    public void Pause()
    {
        Console.WriteLine($"Paused TV program {Name}");
    }
    public void Stop()
    {
        Console.WriteLine($"Stop playing TV program {Name}");
    }
}