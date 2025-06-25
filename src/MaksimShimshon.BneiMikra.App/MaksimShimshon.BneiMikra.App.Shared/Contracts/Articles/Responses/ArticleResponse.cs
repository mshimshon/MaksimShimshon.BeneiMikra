using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;
public record ArticleResponse : ArticleLiteResponse
{
    public CategoryResponse Category { get; set; } = default!;
    public List<BlockResponse> Blocks { get; set; } = new();
}
