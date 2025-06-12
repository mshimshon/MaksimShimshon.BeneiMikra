namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
public record SearchPaginationResponse
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int PageCount { get; set; }
    public int Total { get; set; }
}
