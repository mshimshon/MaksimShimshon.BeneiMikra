namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh;
public record TanakhReferenceResponse
{
    public int Id { get; set; }
    public string Book { get; set; } = default!;
    public int Chapiter { get; set; }
    public int Verse { get; set; }
    public string? Note { get; set; }
    public bool DirectPrint { get; set; }
}
