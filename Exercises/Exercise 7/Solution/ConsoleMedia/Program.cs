using Media;

namespace ConsoleMedia;

internal class Program
{
    static void Main(string[] args)
    {
        var media = new MediaFacade("Patrick", "1234-5678-9123-4567");
        media.SourceSelector<MoviePlayer>();    
        media.Play("Lord of the Rings");
    }
}

class MediaFacade
{
    private PaymentService _paymentService = new PaymentService();
    private IMediaPlayer? _player;
    private Amplifier _amplifier = new Amplifier();
    private readonly string? _user;
    private readonly string? _creditcard;

    public MediaFacade(string? user, string? creditcard)
    {
        _user = user;
        _creditcard = creditcard;
    }
    private void Init()
    {
        if (!_paymentService.Login(_user))
        {
            _paymentService.Register(_user, _creditcard);
            _paymentService.Login(_user);
        }
    }
    public void SourceSelector<T>() where T: class, IMediaPlayer
    {
        if (typeof(T) == typeof(MusicPlayer)) 
        {
            _player = new MusicPlayer(_paymentService);
            return;
        }
        if (typeof(T) == typeof(TVPlayer))
        {
            _player = new TVPlayer(_paymentService);
            return;
        }
        if (typeof(T) == typeof(PodcastPlayer))
        {
            _player = new PodcastPlayer(_paymentService);
            return;
        }
        if (typeof(T) == typeof(MoviePlayer))
        {
            _player = new MoviePlayer(_paymentService);
            return;
        }
    }
    public void Play(string item)
    {
        Init();
        var token = _paymentService.RequestAccess(_user, item);
        if (token != null && _user != null)
        {
            _player?.Play(token, _user, item);
        }
    }
    public void Stop()
    {
        _player?.Stop();
    }
    public void Pause()
    {
        _player?.Pause();   
    }
    public void VolumeUp()
    {
        _amplifier.Up(10);
    }
    public void VolumeDown()
    {
        _amplifier.Up(-10);
    }
}