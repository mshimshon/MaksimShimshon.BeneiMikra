namespace MaksimShimshon.BneiMikra.App.Shared.Services.Interfaces;
public interface IJSProvider
{

    ValueTask InvokeVoidAsync(string identifier, CancellationToken cancellationToken, params object?[]? args);
    ValueTask<TValue> InvokeAsync<TValue>(string identifier, CancellationToken cancellationToken, params object?[]? args);
}
