using Strapi.Net;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Strapi;
internal class StrapiHttpClient : IHttpStrapiClient
{
    private readonly HttpClient _httpClient;

    public StrapiHttpClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    public Task<HttpResponseMessage> GetAsync(string uri, CancellationToken cancellationToken = default)
    {

    }
    public Task<HttpResponseMessage> PatchAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken = default)
        => throw new NotImplementedException();
    public Task<HttpResponseMessage> PostAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken = default)
        => throw new NotImplementedException();
    public Task<HttpResponseMessage> PutAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken = default)
        => throw new NotImplementedException();
    public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken = default)
        => throw new NotImplementedException();
}
