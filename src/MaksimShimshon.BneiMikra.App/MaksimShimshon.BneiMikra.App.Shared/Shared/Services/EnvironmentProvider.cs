using MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;

namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services;
internal class EnvironmentProvider : IEnvironmentProvider
{
    private EnvironmentType _environment;
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
