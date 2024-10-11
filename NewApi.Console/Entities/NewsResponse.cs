using Newtonsoft.Json;

namespace NewApi.Console.Entities
{
    public class NewsResponse
    {
        [JsonProperty("articles")] 
        public List<Article> Articles { get; set; }

    }
}