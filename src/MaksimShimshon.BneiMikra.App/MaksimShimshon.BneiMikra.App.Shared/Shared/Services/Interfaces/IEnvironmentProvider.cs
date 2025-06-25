namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Interfaces;
public interface IEnvironmentProvider
{
    bool IsDebug();
    bool IsRelease();

}
public enum EnvironmentType
{
    Debug,
    Release
}
