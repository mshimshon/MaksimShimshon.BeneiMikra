namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Strapi.Dto;
public record StrapiErrorField
{
    public string[]? Path { get; set; }
    public string? Message { get; set; }
}
