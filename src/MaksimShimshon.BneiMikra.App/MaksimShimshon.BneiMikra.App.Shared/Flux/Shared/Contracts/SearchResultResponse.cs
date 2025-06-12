namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
public record SearchResultResponse<T> where T : class
{
    public List<T> Result { get; set; } = new();
    public SearchPaginationResponse Pagination { get; set; } = new();
}
