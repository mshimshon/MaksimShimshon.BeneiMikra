namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Strapi.Dto;
public record StrapiErrorDetails
{
    public List<StrapiErrorField>? Errors { get; set; }
}
