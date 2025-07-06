using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh.Mapping;
internal class TanakhRefToEntityMap : ICoreMapHandler<TanakhReferenceResponse, TanakhReferenceEntity>
{
    public TanakhReferenceEntity Handler(TanakhReferenceResponse data) => new()
    {
        Note = data.Note,
        Reference = new(TanakhBookMapper.Get(data.Book), data.Chapiter, data.Verse)
    };


    public async Task<TanakhReferenceEntity> HandlerAsync(TanakhReferenceResponse data)
        => await Task.FromResult(Handler(data));
}
