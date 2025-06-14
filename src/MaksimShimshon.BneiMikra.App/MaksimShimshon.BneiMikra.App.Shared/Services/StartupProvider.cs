using Microsoft.JSInterop;

namespace MaksimShimshon.BneiMikra.App.Shared.Services;
internal class StartupProvider : IStartupProvider
{
    private readonly IJSRuntime _jSRuntime;

    public StartupProvider(IJSRuntime jSRuntime)
    {
        _jSRuntime = jSRuntime;
    }
    public Task Start(CancellationToken cancellationToken = default)
    {
        JavaScriptProvider.JSRuntime = _jSRuntime;
        return Task.CompletedTask;
    }
}
