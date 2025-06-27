namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
public record SearchResultEntity<TEntity>
{
    public ICollection<TEntity> Entities { get; init; } = new List<TEntity>();
    public int Page { get; init; }
}
