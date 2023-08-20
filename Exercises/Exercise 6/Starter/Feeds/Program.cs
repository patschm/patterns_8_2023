namespace Feeds;

internal class Program
{
    static HttpClient _client = new HttpClient { BaseAddress = new Uri("https://nu.nl/") };

    static void Main()
    {
        var reader = new FeedReader(_client);
        ShowFeed(reader);
    }

    private static void ShowFeed(FeedReader reader)
    {
        foreach (var item in reader.Read())
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(item.Category);
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(item.Title);
            Console.ResetColor();
            Console.WriteLine(item.Description);
            Console.WriteLine();
        }
    }
}
        
