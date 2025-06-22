namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Actions;
public record ArticleSearchAction(string Keywords, string SortBy) : ISafeAction
{
    public string? Category { get; set; }
}
