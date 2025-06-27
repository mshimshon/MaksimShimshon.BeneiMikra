using MaksimShimshon.BneiMikra.App.Shared.Application.Authors.Pulses.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Authors.Pulses.Stores;
[FeatureState]
public record AuthorViewState : IStateFeature
{
    public bool IsLoading { get; set; }
    public AuthorResponse? Result { get; set; }

}
