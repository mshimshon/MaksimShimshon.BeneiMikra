using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Stores;

public record TeachingState : IStateFeature
{
    public bool IsLoading { get; set; }
    public List<TeachingResponse>? Teachings { get; set; }
}
