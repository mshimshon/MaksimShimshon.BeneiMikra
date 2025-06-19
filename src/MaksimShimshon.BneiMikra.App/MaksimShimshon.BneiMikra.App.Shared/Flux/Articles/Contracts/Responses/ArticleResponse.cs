namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
public record ArticleResponse : ArticleLiteResponse
{
    public CategoryResponse Category { get; set; } = default!;
    public List<BlockResponse> Blocks { get; set; } = new();
}
