using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Articles.Contracts.Responses;
using MaksimShimshon.BneiMikra.App.Shared.Pulsars.Shared.Contracts;

namespace MaksimShimshon.BneiMikra.App.Shared.Pulsars.Teachings.Contracts.Responses;
public record TeachingResponse : BaseEntityResponse
{
    public string Locale { get; set; } = default!;
    public string Title { get; set; } = default!;
    public ArticleLiteResponse Article { get; set; } = default!;
}
