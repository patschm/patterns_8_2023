namespace Feeds
{
    public class FeedReader
    {
        private HttpClient client;
        private IProcessStreamStrategy _strategy;

        public FeedReader(HttpClient http, IProcessStreamStrategy strategy)
        {
            client = http;
            _strategy = strategy;
        }

        public IEnumerable<Item> Read()
        {
            var result = client.GetAsync("rss").Result;
            if (result.IsSuccessStatusCode)
            {
                return _strategy.Process(result.Content.ReadAsStream());
            }
            return null;
        }
    }
}