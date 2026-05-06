namespace P2EngineRepo.DataTypes;

public sealed class EngineInputs
{
    public float[] VoltageA { get; init; } = System.Array.Empty<float>();
    public float[] CurrentA { get; init; } = System.Array.Empty<float>();
    public double SamplingRate { get; init; } = 32000.0;
    public double NominalFrequencyHz { get; init; } = 50.0;
}
