using MaksimShimshon.BneiMikra.App.Shared.Contracts.Teachings.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Teachings.Stores;

public record TeachingState : IStateFeature
{
    public bool IsLoading { get; set; }
    public List<TeachingResponse>? Teachings { get; set; }
}
