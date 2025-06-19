using MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Author.Stores;
[FeatureState]
public record AuthorViewState
{
    public bool IsLoading { get; set; }
    public AuthorResponse? Result { get; set; }

}
