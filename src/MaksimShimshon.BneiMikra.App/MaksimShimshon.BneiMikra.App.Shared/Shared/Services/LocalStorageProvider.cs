using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Text.Json;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services;
internal class LocalStorageProvider : ILocalStorageProvider
{
    private readonly IJSProvider _jSProvider;

    public LocalStorageProvider(IJSProvider jSProvider)
    {
        _jSProvider = jSProvider;
    }

    public async Task<TEntity?> Get<TEntity>(string key, CancellationToken cancellationToken = default) where TEntity : class
    {
        key = key.ToLower();
        var item = await _jSProvider.InvokeAsync<string>("localStorage.getItem", cancellationToken, key);
        if (string.IsNullOrEmpty(item)) return default;

        return JsonSerializer.Deserialize<TEntity>(item);
    }
    public async Task Set<TEntity>(string key, TEntity? entity, CancellationToken cancellationToken = default) where TEntity : class
    {
        key = key.ToLower();
        if (entity == default)
            await _jSProvider.InvokeVoidAsync("localStorage.removeItem", cancellationToken, key);
        else
            await _jSProvider.InvokeVoidAsync("localStorage.setItem", cancellationToken, key, JsonSerializer.Serialize(entity));

    }
    public async Task<IConfiguration> Get(string key, CancellationToken cancellationToken = default)
    {
        key = key.ToLower();
        var item = await _jSProvider.InvokeAsync<string>("localStorage.getItem", cancellationToken, key);
        return new ConfigurationBuilder().AddJsonStream(new MemoryStream(Encoding.ASCII.GetBytes(item))).Build();
    }
}
