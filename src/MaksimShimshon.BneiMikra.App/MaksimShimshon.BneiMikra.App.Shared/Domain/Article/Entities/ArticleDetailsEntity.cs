using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;

namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
public record ArticleDetailsEntity
{
    public IReadOnlyCollection<BlockComponent> BodyParts { get; init; } = new List<BlockComponent>();

}
