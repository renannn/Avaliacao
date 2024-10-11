using NewApi.Console.Requests;
using Refit;

namespace NewApi
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiKey = "1b0baa0274f349b4bb4040d15d9eb258";
            var country = "br";
            
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://newsapi.org"),
                DefaultRequestHeaders = { { "User-Agent", "Refit" } }
            };

            var newsApi = RestService.For<INewsApi>(httpClient);
            var newsResponse = await newsApi.GetTopHeadlinesAsync(country, apiKey);

            foreach (var article in newsResponse.Articles)
            {
                System.Console.WriteLine($"Author: {article.Author}");
                System.Console.WriteLine($"Title: {article.Title}");
                System.Console.WriteLine($"Description: {article.Description}");
                System.Console.WriteLine(new string('-', 50));
            }
        }
    }
}