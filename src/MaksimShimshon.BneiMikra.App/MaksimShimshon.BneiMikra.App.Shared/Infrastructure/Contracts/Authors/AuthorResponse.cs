using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Authors;
public record AuthorResponse : AuthorLiteResponse
{
    public List<ArticleLiteResponse>? Articles { get; set; }
    public ArticleResponse? Biography { get; set; }
}
