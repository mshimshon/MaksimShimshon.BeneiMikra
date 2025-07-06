using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components.Blocks.Mapping;
internal class TanakhReferenceToBlockComponent : ICoreMapHandler<TanakhReferenceResponse, BlockComponent>
{
    private readonly ICoreMap _coreMap;

    public TanakhReferenceToBlockComponent(ICoreMap coreMap)
    {
        _coreMap = coreMap;
    }
    public BlockComponent Handler(TanakhReferenceResponse data) => new BlockComponent()
    {
        Component = nameof(TanakhReference),
        Paramaters = new Dictionary<string, object?>()
        {
            [nameof(TanakhReference.Data)] = _coreMap.MapTo<TanakhReferenceResponse, TanakhReferenceEntity>(data),
            [nameof(TanakhReference.DirectPrint)] = data.DirectPrint,

        }
    };
    public async Task<BlockComponent> HandlerAsync(TanakhReferenceResponse data) => await Task.FromResult(Handler(data));
}
