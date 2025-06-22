using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Actions;
public record TeachingGetResultAction : IAction
{
    public bool IsLoading { get; set; }
    public List<TeachingResponse>? Result { get; set; }
}
