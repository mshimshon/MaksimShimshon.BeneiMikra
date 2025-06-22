using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Stores;

public record ArticleViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public ArticleResponse? Result { get; set; }
}
