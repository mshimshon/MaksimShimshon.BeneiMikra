using MaksimShimshon.BneiMikra.App.Shared.Contracts.Articles.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Stores;

public record ArticleViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public ArticleResponse? Result { get; set; }
}
