using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Contracts.Responses;
public record AuthorResponse : AuthorLiteResponse
{
    public List<ArticleLiteResponse>? Articles { get; set; }
    public ArticleResponse? Biography { get; set; }
}
