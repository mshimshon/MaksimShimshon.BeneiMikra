namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.CoreMap;
public interface ICoreMapper
{
    TDestination MapTo<TOrigin, TDestination>(TOrigin origin);
    Task<TDestination> MapToAsync<TOrigin, TDestination>(TOrigin origin);
}
