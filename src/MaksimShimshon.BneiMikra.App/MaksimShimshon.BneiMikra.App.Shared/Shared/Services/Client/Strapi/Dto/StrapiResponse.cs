namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Services.Client.Strapi.Dto;
public record StrapiResponse<TData>
{
    public List<TData> Data { get; set; } = new();

    public StrapiMeta Meta { get; set; } = default!;
    public List<StrapiError> Errors { get; set; } = new();
}
