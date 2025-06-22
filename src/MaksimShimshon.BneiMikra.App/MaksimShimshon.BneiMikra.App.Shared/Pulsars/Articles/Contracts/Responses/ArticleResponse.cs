using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;
public record ArticleResponse : ArticleLiteResponse
{
    public CategoryResponse Category { get; set; } = default!;
    public List<BlockResponse> Blocks { get; set; } = new();
}
