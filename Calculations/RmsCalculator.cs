namespace P2EngineRepo.Calculations;

public static class RmsCalculator
{
    public static double Calculate(float[] samples)
    {
        if (samples == null || samples.Length == 0) return 0.0;
        double sumSquares = 0.0;
        foreach (float sample in samples) sumSquares += sample * sample;
        return System.Math.Sqrt(sumSquares / samples.Length);
    }
}
