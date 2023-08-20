using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Feeds
{
    public class FeedReader
    {
        private HttpClient client;

        public FeedReader(HttpClient http)
        {
            client = http;
        }

        public IEnumerable<Item> Read()
        {
            var result = client.GetAsync("rss").Result;
            if (result.IsSuccessStatusCode)
            {
                // TODO
               // return ProcessLinqToXml(result.Content.ReadAsStream());
                //return ProcessXmlSerializer(result.Content.ReadAsStream());
                return ProcessRegexp(result.Content.ReadAsStream());
            }
            return null;
        }

        private IEnumerable<Item> ProcessLinqToXml(Stream stream)
        {
            XDocument doc = XDocument.Load(stream);

            var query = from item in doc.Descendants("item")
                        select new Item
                        {
                            Title = item.Element("title")?.Value,
                            Description = item.Element("description")?.Value,
                            Category = item.Element("category")?.Value,
                        };
            return query;
        }

        private IEnumerable<Item> ProcessXmlSerializer(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(Item));

            var reader = XmlReader.Create(stream);
            while (reader.ReadToFollowing("item"))
            {
                var item = serializer.Deserialize(reader.ReadSubtree()) as Item;
                if (item != null) yield return item;
            }
        }

        private IEnumerable<Item> ProcessRegexp(Stream stream)
        {
            StreamReader rdr = new StreamReader(stream);
            string data = rdr.ReadToEnd();
            Regex reg = new Regex(@"<item>.*?<title>(?<title>.*?)</title>.*?<description>(?<desc>.*?)</description>.*?<category>(?<cat>.*?)</category>.*?</item>", RegexOptions.None);
            var mc = reg.Matches(data);
            foreach (Match it in mc)
            {
                yield return new Item
                {
                    Title = it.Groups["title"].Value,
                    Description = it.Groups["desc"].Value,
                    Category = it.Groups["cat"].Value
                };
            }
        }
    }
}