using MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Author.Stores;
[FeatureState]
public record AuthorViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public AuthorResponse? Result { get; set; }

}
