namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
public interface IStartupProvider
{
    /// <summary>
    /// Should be Called in Initialize wihtin Blazor.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task Start(CancellationToken cancellationToken = default);
}
