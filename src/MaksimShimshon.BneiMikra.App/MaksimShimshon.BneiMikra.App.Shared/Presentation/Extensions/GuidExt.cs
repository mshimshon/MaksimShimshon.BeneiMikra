namespace MaksimShimshon.BneiMikra.App.Shared.Presentation.Extensions;
public static class GuidExt
{
    public static void ConvertStringAndSetGuid(this string str, Action<Guid> onSet)
    {
        if (Guid.TryParseExact(str, "D", out var result))
            onSet.Invoke(result);
        else onSet.Invoke(Guid.Empty);
    }
}
