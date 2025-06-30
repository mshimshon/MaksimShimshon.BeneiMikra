namespace MaksimShimshon.BneiMikra.App.Shared.Domain.Errors.Entities;
public record ValidationErrorEntity
{
    public string Code { get; init; } = default!;
    public string Message { get; init; } = default!;

}
