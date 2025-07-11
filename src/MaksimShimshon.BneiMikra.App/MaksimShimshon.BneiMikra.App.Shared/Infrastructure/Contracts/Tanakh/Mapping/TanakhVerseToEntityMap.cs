using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.ValueObjects;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh.Mapping;
internal class TanakhVerseToEntityMap : ICoreMapHandler<TanakhVerseResponse, TanakhVerseEntity>
{
    public TanakhVerseEntity Handler(TanakhVerseResponse data, ICoreMap alsoMap) => new()
    {
        Hebrew = data.Hebrew,
        Reference = new BookReference(TanakhBookMapper.Get(data.Book), data.Chapiter, data.Verse),
        Translated = data.Translated
    };

}
