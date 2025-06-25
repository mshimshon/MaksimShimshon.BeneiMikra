using MaksimShimshon.BneiMikra.App.Shared.Contracts.Teachings.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Pulses.Teachings.Actions;
public record TeachingGetResultAction : IAction
{
    public bool IsLoading { get; set; }
    public List<TeachingResponse>? Result { get; set; }
}
