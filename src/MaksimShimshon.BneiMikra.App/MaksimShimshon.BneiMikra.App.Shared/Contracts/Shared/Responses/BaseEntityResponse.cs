namespace MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;
public abstract record BaseEntityResponse
{
    public int Id { get; set; }
    public string DocumentId { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime PublishedAt { get; set; }

}
