namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
public record StrapiResponse<TData>
{

    public TData? Data { get; set; }
    public StrapiMetaResponse? Meta { get; set; }
    public ErrorResponse? Error { get; set; }
}
