using MaksimShimshon.BneiMikra.App.Shared.Flux.System.Actions;
using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using System.Diagnostics;
using System.Net;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services;
internal class DispatcherClient : IDispatcherClient
{
    private readonly IHttpClientProvider _httpClientProvider;
    private readonly IDispatcher _dispatcher;
    public IResourceProvider<ApplicationResource> ApplicationResourceProvider { get; }

    public DispatcherClient(IHttpClientProvider httpClientProvider, IDispatcher dispatcher, IResourceProvider<ApplicationResource> applicationResourceProvider)
    {
        _httpClientProvider = httpClientProvider;
        _dispatcher = dispatcher;
        ApplicationResourceProvider = applicationResourceProvider;
    }


    public async Task DispatchApi(Func<IHttpClient, Task<HttpResponseMessage>> OnCall, Func<HttpResponseMessage, Task> whenSuccess, Func<Task> whenAnyFailure, Func<HttpResponseMessage, Task>? overrideLoginRequired = null, Func<HttpResponseMessage, Task>? overridePermissionDenied = null, Func<HttpResponseMessage, Task>? overrideException = null)
    {
        try
        {
            var client = _httpClientProvider.CreateClient();

            var httpResult = await OnCall(client);
            if (!httpResult.IsSuccessStatusCode) await whenAnyFailure();
            if (httpResult.IsSuccessStatusCode)
                await whenSuccess(httpResult);
            else if (httpResult.StatusCode == HttpStatusCode.Unauthorized)
                if (overrideLoginRequired != default) await overrideLoginRequired(httpResult);
                else
                    SnackPushError(ApplicationResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnauthorized));
            else if (httpResult.StatusCode == HttpStatusCode.Forbidden)
                if (overridePermissionDenied != default) await overridePermissionDenied(httpResult);
                else
                    SnackPushError(ApplicationResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeForbidden));
            else
            {
#if DEBUG
                var message = await httpResult.Content.ReadAsStringAsync();
                var url = httpResult.RequestMessage.RequestUri;
                Debugger.Break();
#endif
                SnackPushError(ApplicationResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown));
            }
        }
        catch (Exception ex)
        {
#if DEBUG
            Console.WriteLine(ex.Message);
#endif
            await whenAnyFailure();
            SnackPushError(ApplicationResourceProvider.GetString(() => ApplicationResource.HttpStatusCodeUnknown));
        }


    }
    private void SnackPushError(string errorMessage)
    {
        var stateResult = new SnackPushNotificationAction(Severity.Error)
        {
            Message = errorMessage
        };
        _dispatcher.Dispatch(stateResult);
    }
}

