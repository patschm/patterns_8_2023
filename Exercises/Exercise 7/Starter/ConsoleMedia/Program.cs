using Media;

namespace ConsoleMedia;

internal class Program
{
    static void Main(string[] args)
    {
        PaymentService paymentService = new PaymentService();
        IMediaPlayer? player = new MoviePlayer(paymentService);
        Amplifier amplifier = new Amplifier();
        if (!paymentService.Login("Patrick"))
        {
            paymentService.Register("Patrick", "1234-5678-9123-4567");
        }
        paymentService.Login("Patrick");

        var token = paymentService.RequestAccess("Patrick", "Lord of the Rings");
        player?.Play(token!, "Patrick", "Lord of the Rings");
        amplifier.Up(10);
        player?.Pause();
        player?.Play(token!, "Patrick", "Lord of the Rings");
        player?.Stop();

    }
}
