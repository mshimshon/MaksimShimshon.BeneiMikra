namespace MaksimShimshon.BneiMikra.App.Shared.Services.Interfaces;
public interface IHttpClient
{
    Task<HttpResponseMessage> GetAsync(string uri, CancellationToken cancellationToken = default);
    Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken = default);
    Task<HttpResponseMessage> PatchAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken = default);
    Task<HttpResponseMessage> PostAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken = default);
    Task<HttpResponseMessage> PutAsync(string uri, HttpContent httpContent, CancellationToken cancellationToken = default);
}
