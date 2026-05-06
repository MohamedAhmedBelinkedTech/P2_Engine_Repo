using P2EngineRepo.DataTypes;
namespace P2EngineRepo.Calculations;
public static class SimpleHarmonicCalculator
{
    public static HarmonicSummary CalculateDemoSummary(double fundamental, double third, double fifth)
    {
        double thd = fundamental == 0 ? 0 : System.Math.Sqrt(third*third + fifth*fifth) / fundamental;
        return new HarmonicSummary { Fundamental = fundamental, Third = third, Fifth = fifth, TotalHarmonicDistortion = thd };
    }
}
