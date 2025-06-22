using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Author.Stores;
[FeatureState]
public record AuthorViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public AuthorResponse? Result { get; set; }

}
