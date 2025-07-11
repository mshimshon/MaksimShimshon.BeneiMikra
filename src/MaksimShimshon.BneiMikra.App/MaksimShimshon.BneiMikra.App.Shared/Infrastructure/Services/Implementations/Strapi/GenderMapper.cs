using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Services.Implementations.Strapi;
internal static class GenderMapper
{
    public static Dictionary<string, Gender> Mapper { get; } = new()
    {
        ["Male"] = Gender.Male,
        ["Female"] = Gender.Female,
        ["Both"] = Gender.NA
    };
}
