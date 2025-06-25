namespace MaksimShimshon.BneiMikra.App.Shared.Shared.Extensions;
public static class MathExt
{

    public static double GetTolerance(this double self, double other) => Math.Abs(self - other);
    public static float GetTolerance(this float self, float other) => Math.Abs(self - other);
    public static bool IsApproximately(this double self, double other, double faultTolerance = 0.00001)
    {
        return self.GetTolerance(other) <= faultTolerance;
    }

    public static bool IsApproximately(this float self, float other, float faultTolerance = 0.00001f)
    {
        return self.GetTolerance(other) <= faultTolerance;
    }
}
