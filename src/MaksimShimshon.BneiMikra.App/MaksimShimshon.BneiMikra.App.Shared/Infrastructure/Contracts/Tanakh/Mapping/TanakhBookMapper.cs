using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh.Mapping;
internal static class TanakhBookMapper
{
    public static Dictionary<string, TanakhBook> Mapper { get; } = new()
    {
        [""] = TanakhBook.Unknown
    };
}
