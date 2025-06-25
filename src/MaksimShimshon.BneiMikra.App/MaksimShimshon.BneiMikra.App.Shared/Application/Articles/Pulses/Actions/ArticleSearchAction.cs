namespace MaksimShimshon.BneiMikra.App.Shared.Application.Articles.Pulses.Actions;
public record ArticleSearchAction(string Keywords, string SortBy) : ISafeAction
{
    public string? Category { get; set; }
}
