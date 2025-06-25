namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.CoreMap;
public interface ICoreMapHandler<in TOrigin, TDestination>
{
    TDestination MapHandler(TOrigin data);
    Task<TDestination> MapHandlerAsync(TOrigin data);
}
