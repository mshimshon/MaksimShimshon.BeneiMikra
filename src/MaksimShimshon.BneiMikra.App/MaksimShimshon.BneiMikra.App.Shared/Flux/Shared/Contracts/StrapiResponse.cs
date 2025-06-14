namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
public record StrapiResponse<TData>
{
    public TData? Data { get; set; }
    public ErrorResponse? Error { get; set; }
}
