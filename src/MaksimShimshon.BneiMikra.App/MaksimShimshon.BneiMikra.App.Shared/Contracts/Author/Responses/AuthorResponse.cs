using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Author.Responses;
public record AuthorResponse : AuthorLiteResponse
{
    public List<ArticleLiteResponse>? Articles { get; set; }
    public ArticleResponse? Biography { get; set; }
}
