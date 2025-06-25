using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Extensions;
internal static class HttpUtilityExt
{
    internal class HttpEndpointBuilder
    {
        public string Url { get; init; } = default!;
        public Dictionary<string, string> Query { get; init; } = new();

        public override string ToString()
        {

            var query = string.Join("&", Query.Select(kv => $"{kv.Key}={kv.Value}"));
            if (query == default) return Url;
            return $"{Url}?{query}";
        }
    }
    public static HttpEndpointBuilder CreateEndpoint(this IHttpClient client, string path)
    => new HttpEndpointBuilder() { Url = path };
}
