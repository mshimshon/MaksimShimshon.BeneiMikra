namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Teaching;
public class TeachingEntity
{
    public DateTime PublishedOn { get; init; }
    public DateTime LastRevision { get; init; }
    public string Name { get; init; } = default!;
    public string ArticleId { get; init; } = default!;
}
