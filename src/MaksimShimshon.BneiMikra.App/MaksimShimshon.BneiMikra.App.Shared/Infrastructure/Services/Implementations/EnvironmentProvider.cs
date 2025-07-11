using MaksimShimshon.BneiMikra.App.Shared.Application.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations;
internal class EnvironmentProvider : IEnvironmentProvider
{
    private readonly EnvironmentType _environment;
    public EnvironmentProvider()
    {
#if DEBUG
        _environment = EnvironmentType.Debug;
#else
        _environment = EnvironmentType.Release;
#endif
    }
    public bool IsDebug() => _environment == EnvironmentType.Debug;
    public bool IsRelease() => _environment == EnvironmentType.Release;
}
