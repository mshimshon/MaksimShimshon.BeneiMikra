using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Stores;

public record ArticleSearchState : IStateFeature
{
    public bool IsLoading { get; set; }
    public SearchResultResponse<ArticleLiteResponse>? Result { get; set; }
}
