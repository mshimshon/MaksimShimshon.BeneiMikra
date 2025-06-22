using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
public record ArticleSearchResultAction : IAction
{
    public bool IsLoading { get; set; }
    public SearchResultResponse<ArticleLiteResponse>? Result { get; set; }
}
