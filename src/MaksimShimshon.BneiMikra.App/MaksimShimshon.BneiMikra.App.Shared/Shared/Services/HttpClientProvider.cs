using MaksimShimshon.BneiMikra.App.Shared.Services;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services;
internal class HttpClientProvider : IHttpClientProvider
{
    private readonly IHttpClientFactory _httpClientFactory;

    public HttpClientProvider(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public IHttpClient CreateClient()
    {
        var client = _httpClientFactory.CreateClient();
        var httpClient = new HttpClientWrapper(client);
#if DEBUG
        var url = "http://localhost:1337/";
#else
        string url = "https://localhost:1337/";
#endif
        httpClient.HttpClient.BaseAddress = new Uri(url);
        return httpClient;
    }
}
