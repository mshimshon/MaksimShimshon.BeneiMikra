using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.ValueObjects;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh.Mapping;
internal class TanakhVerseToEntityMap : ICoreMapHandler<TanakhVerseResponse, TanakhVerseEntity>
{
    public TanakhVerseEntity MapHandler(TanakhVerseResponse data) => new()
    {
        Hebrew = data.Hebrew,
        Reference = new BookReference(TanakhBookMapper.Mapper[data.Book], data.Chapiter, data.Verse),
        Translated = data.Translated
    };

    public async Task<TanakhVerseEntity> MapHandlerAsync(TanakhVerseResponse data)
        => await Task.FromResult(MapHandler(data));
}
