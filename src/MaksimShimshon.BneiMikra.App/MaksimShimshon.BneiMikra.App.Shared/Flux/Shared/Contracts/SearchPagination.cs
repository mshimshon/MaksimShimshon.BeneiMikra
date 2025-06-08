namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
public record SearchPagination
{
    public int Page { get; set; }
    public int PageSize { get; set; }
    public int PAgeCount { get; set; }
    public int Total { get; set; }
}
