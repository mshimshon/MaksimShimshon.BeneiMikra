using MaksimShimshon.BneiMikra.App.Shared.Domain.Shared.Enums;

namespace MaksimShimshon.BneiMikra.App.Shared.Infrastructure.Contracts.Tanakh.Mapping;
internal static class TanakhBookMapper
{
    private static Dictionary<string, TanakhBook> Mapper { get; } = new()
    {
        ["Bereshit"] = TanakhBook.Bereshit,
        ["Shemot"] = TanakhBook.Shemot,
        ["Vayikra"] = TanakhBook.Vayikra,
        ["Bamidbar"] = TanakhBook.Bamidbar,
        ["Devarim"] = TanakhBook.Devarim,
        ["Yehoshua"] = TanakhBook.Yehoshua,
        ["Shoftim"] = TanakhBook.Shoftim,
        ["Shmuel Alef"] = TanakhBook.ShmuelAlef,
        ["Shmuel Bet"] = TanakhBook.ShmuelBet,
        ["Melakhim Alef"] = TanakhBook.MelakhimAlef,
        ["Melakhim Bet"] = TanakhBook.MelakhimBet,
        ["Yeshayahu"] = TanakhBook.Yeshayahu,
        ["Yirmeyahu"] = TanakhBook.Yirmeyahu,
        ["Yechezkel"] = TanakhBook.Yechezkel,
        ["Hoshea"] = TanakhBook.Hoshea,
        ["Yoel"] = TanakhBook.Yoel,
        ["Amos"] = TanakhBook.Amos,
        ["Ovadyah"] = TanakhBook.Ovadyah,
        ["Yonah"] = TanakhBook.Yonah,
        ["Mikhah"] = TanakhBook.Mikhah,
        ["Nachum"] = TanakhBook.Nachum,
        ["Havakuk"] = TanakhBook.Havakuk,
        ["Tsefanyah"] = TanakhBook.Tsefanyah,
        ["Haggai"] = TanakhBook.Haggai,
        ["Zekharyah"] = TanakhBook.Zekharyah,
        ["Malakhi"] = TanakhBook.Malakhi,
        ["Tehillim"] = TanakhBook.Tehillim,
        ["Mishlei"] = TanakhBook.Mishlei,
        ["Iyov"] = TanakhBook.Iyov,
        ["Shir Ha Shirim"] = TanakhBook.ShirHaShirim,
        ["Rut"] = TanakhBook.Rut,
        ["Eikhah"] = TanakhBook.Eikhah,
        ["Kohelet"] = TanakhBook.Kohelet,
        ["Esther"] = TanakhBook.Esther,
        ["Daniel"] = TanakhBook.Daniel,
        ["Ezra"] = TanakhBook.Ezra,
        ["Nechemyah"] = TanakhBook.Nechemyah,
        ["Divrei Ha Yamim Alef"] = TanakhBook.DivreiHaYamimAlef,
        ["Divrei Ha Yamim Bet"] = TanakhBook.DivreiHaYamimBet,
        [""] = TanakhBook.Unknown
    };
    public static TanakhBook Get(string book)
        => Mapper.ContainsKey(book) ? Mapper[book] : TanakhBook.Unknown;
}
