using Newtonsoft.Json;

namespace NewApi.Console.Entities
{
    public class Article
    {
        [JsonProperty("author")] public string Author { get; set; }

        [JsonProperty("title")] public string Title { get; set; }

        [JsonProperty("description")] public string Description { get; set; }

    }
}