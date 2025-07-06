namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Article.Entities;
public record ArticleEntity
{
    public string Id { get; init; } = default!;
    public string Title { get; init; } = default!;
    public string Description { get; init; } = default!;
    public DateTime PublishedOn { get; init; }
    public DateTime LastRevision { get; init; }
    public ArticleDetailsEntity? Details { get; init; }
    public ArticleAuthorDetailsEntity? Author { get; init; }
    public List<string> Categories { get; init; } = new();
    public ICollection<ArticleEntity> Related { get; set; } = new List<ArticleEntity>();
}
