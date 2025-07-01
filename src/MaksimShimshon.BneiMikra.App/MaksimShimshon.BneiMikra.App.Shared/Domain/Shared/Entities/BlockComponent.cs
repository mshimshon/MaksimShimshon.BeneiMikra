namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Entities;
public record BlockComponent
{
    public string Component { get; set; }
    public Dictionary<string, object> Paramaters { get; set; } = new();
}
