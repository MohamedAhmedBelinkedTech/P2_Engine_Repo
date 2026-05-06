using P2EngineRepo.DataTypes;
namespace P2EngineRepo.Events;

public sealed class SimpleEventChecker
{
    public void Process(EngineOutputs outputs)
    {
        if (outputs.VoltageRms < 180.0) outputs.Events.Add("VoltageDip");
        if (outputs.CurrentRms > 20.0) outputs.Events.Add("OverCurrent");
    }
}
