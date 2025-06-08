namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;
public record SearchResult<T> where T : class
{
    public List<T> Result { get; set; } = new();
    public SearchPagination Pagination { get; set; } = new();
}
