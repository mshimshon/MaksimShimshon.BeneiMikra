using MaksimShimshon.BneiMikra.App.Shared.Flux.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Flux.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Flux.Teachings.Contracts.Responses;
public record TeachingResponse : BaseEntityResponse
{
    public string Locale { get; set; } = default!;
    public string Title { get; set; } = default!;
    public ArticleLiteResponse Article { get; set; } = default!;
}
