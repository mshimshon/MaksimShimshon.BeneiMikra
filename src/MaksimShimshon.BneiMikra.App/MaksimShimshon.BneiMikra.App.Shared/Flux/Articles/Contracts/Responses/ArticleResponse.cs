using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
public record ArticleResponse : ArticleLiteResponse
{
    public CategoryResponse Category { get; set; } = default!;
    public List<ArticleBlockResponse> Blocks { get; set; } = new();
}
