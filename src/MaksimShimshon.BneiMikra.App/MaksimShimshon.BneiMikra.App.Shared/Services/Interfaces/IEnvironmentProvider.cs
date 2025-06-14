namespace MaksimShimshon.BneiMikra.App.Shared.Services.Interfaces;
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
