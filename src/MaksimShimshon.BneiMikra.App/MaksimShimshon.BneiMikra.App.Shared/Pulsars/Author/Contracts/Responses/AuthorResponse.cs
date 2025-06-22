using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Contracts.Responses;
public record AuthorResponse : AuthorLiteResponse
{
    public List<ArticleLiteResponse>? Articles { get; set; }
    public ArticleResponse? Biography { get; set; }
}
