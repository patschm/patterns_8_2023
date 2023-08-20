namespace DecoratorNS;

internal class Program
{
    static void Main(string[] args)
    {
        var message = new Message();
        var deco1 = new FacebookDecorator(message);
        var deco2 = new TwitterDecorator(deco1);

        deco2.Send("Hello");
    }
}