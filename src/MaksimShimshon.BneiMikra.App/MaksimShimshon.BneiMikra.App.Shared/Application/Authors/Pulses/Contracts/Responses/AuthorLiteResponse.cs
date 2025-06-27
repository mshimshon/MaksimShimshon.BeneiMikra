using MaksimShimshon.BneiMikra.App.Shared.Contracts.Shared.Responses;

namespace MaksimShimshon.BneiMikra.App.Shared.Application.Authors.Pulses.Contracts.Responses;
public record AuthorLiteResponse : BaseEntityResponse
{
    public string Name { get; set; } = default!;
    public string? Email { get; set; }
}
