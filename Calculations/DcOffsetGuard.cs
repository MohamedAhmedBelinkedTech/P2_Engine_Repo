using System.Linq;
namespace P2EngineRepo.Calculations;
public static class DcOffsetGuard
{
    public static bool HasLargeOffset(float[] samples, double limit)
    {
        if (samples == null || samples.Length == 0) return false;
        double avg = samples.Average(x => (double)x);
        return System.Math.Abs(avg) > limit;
    }
}
