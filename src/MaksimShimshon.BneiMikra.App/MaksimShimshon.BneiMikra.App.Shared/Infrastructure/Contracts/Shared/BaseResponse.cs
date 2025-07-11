namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Shared;
public abstract record BaseResponse
{
    public int Id { get; set; }
    public string DocumentId { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime PublishedAt { get; set; }
}
