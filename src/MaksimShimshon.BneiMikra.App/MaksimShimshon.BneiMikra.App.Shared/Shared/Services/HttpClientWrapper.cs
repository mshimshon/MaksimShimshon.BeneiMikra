using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services;
internal class HttpClientWrapper : IHttpClient
{
    public HttpClient HttpClient { get; }

    public HttpClientWrapper(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }
    public async Task<HttpResponseMessage> GetAsync(string uri, CancellationToken cancellationToken = default) => await HttpClient.GetAsync(uri, cancellationToken);
    public async Task<HttpResponseMessage> PatchAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken = default) => await HttpClient.PatchAsync(uri, httpContent, cancellationToken);
    public async Task<HttpResponseMessage> PostAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken = default) => await HttpClient.PostAsync(uri, httpContent, cancellationToken);
    public async Task<HttpResponseMessage> PutAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken = default) => await HttpClient.PutAsync(uri, httpContent, cancellationToken);
    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken = default) => await HttpClient.SendAsync(request, cancellationToken);
}