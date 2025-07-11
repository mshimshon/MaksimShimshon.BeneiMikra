namespace MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;
public interface IJavascriptProvider
{
    ValueTask InvokeVoidAsync(string identifier, CancellationToken cancellationToken, params object?[]? args);
    ValueTask<TValue> InvokeAsync<TValue>(string identifier, CancellationToken cancellationToken, params object?[]? args);
}
