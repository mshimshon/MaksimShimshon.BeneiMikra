namespace MaksimShimshon.BneiMikra.App.Shared.Application.Features.Articles.Pulses.Actions;
public record ArticleSearchAction() : ISafeAction
{
    public string? Keywords { get; init; }
    public string? Category { get; init; }
    public string? SortBy { get; init; }
    public int Page { get; init; }
}
