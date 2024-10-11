using NewApi.Console.Entities;
using Refit;

namespace NewApi.Console.Requests
{
    public interface INewsApi
    {
        [Get("/v2/top-headlines")]
        Task<NewsResponse> GetTopHeadlinesAsync([AliasAs("country")] string country, [AliasAs("apiKey")] string apiKey);

    }
}