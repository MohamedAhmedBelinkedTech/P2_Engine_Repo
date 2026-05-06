using P2EngineRepo.Calculations;
using P2EngineRepo.DataTypes;
using P2EngineRepo.Events;

namespace P2EngineRepo;

public sealed class P2Manager
{
    private readonly SimpleEventChecker _eventChecker = new();
    public static string GetSoftwareVersion() => "P2_Engine_V1.0.0";

    public EngineOutputs Step(EngineInputs inputs)
    {
        var outputs = new EngineOutputs
        {
            VoltageRms = RmsCalculator.Calculate(inputs.VoltageA),
            CurrentRms = RmsCalculator.Calculate(inputs.CurrentA),
            FrequencyHz = inputs.NominalFrequencyHz
        };
        _eventChecker.Process(outputs);
        return outputs;
    }
}
