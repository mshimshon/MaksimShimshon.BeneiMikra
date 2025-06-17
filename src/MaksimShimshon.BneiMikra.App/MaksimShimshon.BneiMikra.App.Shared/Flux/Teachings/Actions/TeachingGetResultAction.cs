using MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Contracts.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Actions;
public record TeachingGetResultAction
{
    public bool IsLoading { get; set; }
    public List<TeachingResponse>? Result { get; set; }
}
