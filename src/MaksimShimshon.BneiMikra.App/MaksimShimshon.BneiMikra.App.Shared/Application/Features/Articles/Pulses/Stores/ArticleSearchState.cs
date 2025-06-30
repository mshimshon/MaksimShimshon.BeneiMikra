using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Articles;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Stores;

public record ArticleSearchState : IStateFeature
{
    public bool IsLoading { get; set; }
    public SearchResultResponse<ArticleLiteResponse>? Result { get; set; }
}
