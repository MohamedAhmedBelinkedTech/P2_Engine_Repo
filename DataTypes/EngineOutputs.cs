using System.Collections.Generic;
namespace P2EngineRepo.DataTypes;

public sealed class EngineOutputs
{
    public double VoltageRms { get; set; }
    public double CurrentRms { get; set; }
    public double FrequencyHz { get; set; }
    public List<string> Events { get; } = new();
}
