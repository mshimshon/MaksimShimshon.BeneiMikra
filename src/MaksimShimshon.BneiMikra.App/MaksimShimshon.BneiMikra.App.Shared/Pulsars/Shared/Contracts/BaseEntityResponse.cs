namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;
public abstract record BaseEntityResponse
{
    public int Id { get; set; }
    public string DocumentId { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime PublishedAt { get; set; }

}
