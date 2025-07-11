using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh;

namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Shared.Components.Blocks.Mapping;
internal class TanakhReferenceToBlockComponent : ICoreMapHandler<TanakhReferenceResponse, BlockComponent>
{

    public BlockComponent Handler(TanakhReferenceResponse data, ICoreMap alsoMap) => new BlockComponent()
    {
        Component = nameof(TanakhReference),
        Paramaters = new Dictionary<string, object?>()
        {
            [nameof(TanakhReference.Data)] = alsoMap.MapTo<TanakhReferenceResponse, TanakhReferenceEntity>(data),
            [nameof(TanakhReference.DirectPrint)] = data.DirectPrint,

        }
    };
}
