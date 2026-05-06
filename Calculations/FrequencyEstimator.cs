namespace P2EngineRepo.Calculations;
public static class FrequencyEstimator
{
    public static double Estimate(float[] samples, double fs)
    {
        if (samples == null || samples.Length < 2 || fs <= 0) return 0.0;
        int crossings = 0; for (int i=1;i<samples.Length;i++) if(samples[i-1]<=0 && samples[i]>0) crossings++;
        return crossings / (samples.Length / fs);
    }
}
