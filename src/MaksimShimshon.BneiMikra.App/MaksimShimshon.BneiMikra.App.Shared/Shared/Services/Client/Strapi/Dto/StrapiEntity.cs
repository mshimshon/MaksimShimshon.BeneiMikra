namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Strapi.Dto;
public record StrapiEntity<TAttributes>
{
    public int Id { get; set; }

    public TAttributes Attributes { get; set; } = default!;
}
