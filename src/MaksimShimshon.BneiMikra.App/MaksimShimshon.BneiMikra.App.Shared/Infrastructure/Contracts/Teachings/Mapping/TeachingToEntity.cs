using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Teachings.Mapping;
internal class TeachingToEntity : ICoreMapHandler<TeachingResponse, TeachingEntity>
{
    public TeachingEntity MapHandler(TeachingResponse data) => new()
    {
        Name = data.Title,
        LastRevision = data.UpdatedAt,
        PublishedOn = data.PublishedAt,
        ArticleId = data.Article.DocumentId
    };

    public async Task<TeachingEntity> MapHandlerAsync(TeachingResponse data)
        => await Task.FromResult(MapHandler(data));
}
