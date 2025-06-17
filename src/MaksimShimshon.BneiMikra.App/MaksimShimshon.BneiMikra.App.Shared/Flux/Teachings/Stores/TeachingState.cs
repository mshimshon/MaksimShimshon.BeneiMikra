using MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Stores;

[FeatureState]
public record TeachingState
{
    public bool IsLoading { get; set; }
    public List<TeachingResponse>? Teachings { get; set; }
}
