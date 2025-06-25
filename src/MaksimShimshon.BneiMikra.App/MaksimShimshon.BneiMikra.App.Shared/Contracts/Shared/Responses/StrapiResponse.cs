namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
public record StrapiResponse<TData>
{

    public TData? Data { get; set; }
    public StrapiMetaResponse? Meta { get; set; }
    public ErrorResponse? Error { get; set; }
}
