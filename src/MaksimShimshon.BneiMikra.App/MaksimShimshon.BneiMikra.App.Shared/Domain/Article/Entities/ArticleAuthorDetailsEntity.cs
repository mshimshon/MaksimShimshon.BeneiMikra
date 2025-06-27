namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Articles.Entities;
public record ArticleAuthorDetailsEntity
{
    public string Name { get; init; } = default!;
    public string Id { get; init; } = default!;
    public string? Picture { get; init; }
}
