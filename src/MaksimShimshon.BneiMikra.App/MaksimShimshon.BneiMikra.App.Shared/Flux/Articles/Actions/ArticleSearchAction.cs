namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Actions;
public record ArticleSearchAction(string Keywords, string SortBy)
{
    public string? Category { get; set; }
}
