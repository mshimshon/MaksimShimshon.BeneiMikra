using MaksimShimshon.BneiMikra.App.Shared.Application.Resources;
using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
using MaksimShimshon.BneiMikra.App.Shared.Application.System.Actions;
using Strapi.Net;
using Strapi.Net.Dto;
using Strapi.Net.Utilities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations.Strapi;

internal class StrapiClient : IStrapiClient
{
    private readonly HttpClient _client;
    private readonly IResourceProvider<ApplicationResource> _appResourceProvider;
    private readonly IDispatcher _dispatcher;

    public StrapiClient(HttpClient client,
        IResourceProvider<ApplicationResource> AppResourceProvider,
        IDispatcher dispatcher)
    {
        _client = client;
        _appResourceProvider = AppResourceProvider;
        _dispatcher = dispatcher;
#if DEBUG
        _client.BaseAddress = new("http://localhost:1337/api/");
#else
        _client.BaseAddress = new("https://api.bneimikra.com/api/");
#endif
    }
    private async Task<TResult?> RequestHandler<TResult>(Func<Task<TResult>> call)
    {
        try
        {
            return await call();
        }
        catch (Exception ex)
        {
            await _dispatcher.Prepare<PushErrorMessageAction>()
                .With(p => p.Message, _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown))
                .DispatchAsync();
        }
        return default;
    }
    public async Task<StrapiResponse<TEntity>?> DeleteAsync<TEntity>(string uri, CancellationToken cancellationToken = default)
    {

        var result = await RequestHandler(() => _client.DeleteAsync(uri, cancellationToken));
        if (result == default) return default;
        if (!result.IsSuccessStatusCode) await HandleErrors(result);
        if (result != default && result.Content != default)
        {
            var json = await result.Content.ReadAsStringAsync();
            return StrapiDecoder.DecodeResponse<TEntity>(json);
        }
        return default;
    }

    public async Task<StrapiResponse<TEntity>?> GetAsync<TEntity>(string uri, CancellationToken cancellationToken = default)
    {

        var result = await RequestHandler(() => _client.GetAsync(uri, cancellationToken));
        if (result == default) return default;

        if (!result.IsSuccessStatusCode) await HandleErrors(result);
        if (result != default && result.Content != default)
        {
            var json = await result.Content.ReadAsStringAsync();
            return StrapiDecoder.DecodeResponse<TEntity>(json);
        }
        return default;
    }

    public async Task<StrapiResponse<TEntity>?> PatchAsync<TEntity>(string uri, HttpContent httpContent, CancellationToken cancellationToken = default)
    {
        var result = await RequestHandler(() => _client.PatchAsync(uri, httpContent, cancellationToken));
        if (result == default) return default;
        if (!result.IsSuccessStatusCode) await HandleErrors(result);



        if (result != default && result.Content != default)
        {
            var json = await result.Content.ReadAsStringAsync();
            return StrapiDecoder.DecodeResponse<TEntity>(json);
        }
        return default;
    }
    public async Task<StrapiResponse<TEntity>?> PostAsync<TEntity>(string uri, HttpContent httpContent, CancellationToken cancellationToken = default)
    {
        var result = await RequestHandler(() => _client.PostAsync(uri, httpContent, cancellationToken));
        if (result == default) return default;
        if (!result.IsSuccessStatusCode) await HandleErrors(result);
        if (result != default && result.Content != default)
        {
            var json = await result.Content.ReadAsStringAsync();
            return StrapiDecoder.DecodeResponse<TEntity>(json);
        }
        return default;
    }
    public async Task<StrapiResponse<TEntity>?> PutAsync<TEntity>(string uri, HttpContent httpContent, CancellationToken cancellationToken = default)
    {
        var result = await RequestHandler(() => _client.PutAsync(uri, httpContent, cancellationToken));
        if (result == default) return default;
        if (!result.IsSuccessStatusCode) await HandleErrors(result);
        if (result != default && result.Content != default)
        {
            var json = await result.Content.ReadAsStringAsync();
            return StrapiDecoder.DecodeResponse<TEntity>(json);
        }
        return default;
    }

    private async Task HandleErrors(HttpResponseMessage message)
    {

        if (message.StatusCode == System.Net.HttpStatusCode.NotFound)
            await _dispatcher.Prepare<PushErrorMessageAction>()
                .With(p => p.Message, _appResourceProvider.GetString(() => ApplicationResource.HttpStatusNotFound))
                .DispatchAsync();
        else if (message.StatusCode == System.Net.HttpStatusCode.BadRequest)
            await _dispatcher.Prepare<PushErrorMessageAction>()
                .With(p => p.Message, _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeBadRequest))
                .DispatchAsync();
        else if (message.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            await _dispatcher.Prepare<PushErrorMessageAction>()
                .With(p => p.Message, _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnauthorized))
                .DispatchAsync();
        else if (message.StatusCode == System.Net.HttpStatusCode.Forbidden)
            await _dispatcher.Prepare<PushErrorMessageAction>()
                .With(p => p.Message, _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeForbidden))
                .DispatchAsync();
        else
            await _dispatcher.Prepare<PushErrorMessageAction>()
                .With(p => p.Message, _appResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown))
                .DispatchAsync();
    }
}
