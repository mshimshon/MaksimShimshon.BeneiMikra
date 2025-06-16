using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
public record ArticleSearchResultAction
{
    public bool IsLoading { get; set; }
    public SearchResultResponse<ArticleLiteResponse>? Result { get; set; }
}
