using CoreMap;
using MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Teachings.Mapping;
internal class TeachingToEntity : ICoreMapHandler<TeachingResponse, TeachingEntity>
{
    public TeachingEntity Handler(TeachingResponse data, ICoreMap alsoMap) => new()
    {
        Name = data.Title,
        LastRevision = data.UpdatedAt,
        PublishedOn = data.PublishedAt,
        ArticleId = data.Article.DocumentId
    };

}
