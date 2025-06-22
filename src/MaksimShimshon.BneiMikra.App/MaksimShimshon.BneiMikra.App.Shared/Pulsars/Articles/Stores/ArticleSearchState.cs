using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Stores;

public record ArticleSearchState : IStateFeature
{
    public bool IsLoading { get; set; }
    public SearchResultResponse<ArticleLiteResponse>? Result { get; set; }
}
