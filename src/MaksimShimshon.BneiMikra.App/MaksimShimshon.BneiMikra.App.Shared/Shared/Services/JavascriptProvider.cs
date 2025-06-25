using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
using Microsoft.JSInterop;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services;
public class JavaScriptProvider : IJSProvider
{
    public static IJSRuntime? JSRuntime { get; set; }
    public static async Task WaitUntilRuntimeAvailable(CancellationToken cancellationToken = default)
    {
        if (JSRuntime != default) return;
        while (true)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (JSRuntime != default) return;
            await Task.Delay(100);
        }
    }
    public async ValueTask<TValue> InvokeAsync<TValue>(string identifier, CancellationToken cancellationToken, params object?[]? args)
    {
        await WaitUntilRuntimeAvailable(cancellationToken);
        return await JSRuntime!.InvokeAsync<TValue>(identifier, cancellationToken, args);
    }

    public async ValueTask InvokeVoidAsync(string identifier, CancellationToken cancellationToken, params object?[]? args)
    {

        await WaitUntilRuntimeAvailable(cancellationToken);
        await JSRuntime!.InvokeVoidAsync(identifier, cancellationToken, args);
    }
}
