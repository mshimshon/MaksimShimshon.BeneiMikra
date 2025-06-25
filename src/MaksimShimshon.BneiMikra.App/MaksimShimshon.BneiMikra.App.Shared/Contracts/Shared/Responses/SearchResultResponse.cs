namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
public record SearchResultResponse<T> where T : class
{
    public List<T> Result { get; set; } = new();
    public SearchPaginationResponse Pagination { get; set; } = new();
}
