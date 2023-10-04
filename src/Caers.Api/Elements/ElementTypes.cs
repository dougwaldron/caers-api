using JetBrains.Annotations;
using System.Text.Json;

namespace Caers.Api.Elements;

// Abstract types

public abstract record Element
{
    public JsonElement Value { get; init; }
}

public abstract record ElementCollection<TElement>(JsonElement Value) where TElement : Element, new()
{
    public IEnumerable<TElement> Values => Value.EnumerateArray().Select(element => new TElement { Value = element });
}

// Concrete types

public record Report(JsonElement Value)
{
    public FacilitySite GetFirstFacility() => new()
        { Value = Value.GetProperty(FacilitySite.Property).EnumerateArray().First() };
}

public record FacilitySite : Element
{
    public static string Property => "facilitySite";
    public EmissionsUnits GetEmissionsUnits() => new(Value.GetProperty(EmissionsUnits.Property));
}

public record EmissionsUnits(JsonElement Value) : ElementCollection<EmissionsUnit>(Value)
{
    public static string Property => "emissionsUnits";
}

[UsedImplicitly]
public record EmissionsUnit : Element
{
    public EmissionsProcesses GetEmissionsProcesses() => new(Value.GetProperty(EmissionsProcesses.Property));
}

public record EmissionsProcesses(JsonElement Value) : ElementCollection<EmissionsProcess>(Value)
{
    public static string Property => "emissionsProcesses";
}

[UsedImplicitly]
public record EmissionsProcess : Element
{
    public ReportingPeriods GetReportingPeriods() => new(Value.GetProperty(ReportingPeriods.Property));
}

public record ReportingPeriods(JsonElement Value) : ElementCollection<ReportingPeriod>(Value)
{
    public static string Property => "reportingPeriods";
}

[UsedImplicitly]
public record ReportingPeriod : Element
{
    public Emissions GetEmissions() => new(Value.GetProperty(Emissions.Property));
}

public record Emissions(JsonElement Value) : ElementCollection<Emission>(Value)
{
    public static string Property => "emissions";
}

public record Emission : Element
{
    private static string PollutantCode => "pollutantCode";
    private static string TotalEmissions => "totalEmissions";
    public bool PollutantCodeEquals(string s) => Value.GetProperty(PollutantCode).GetProperty(PollutantCode).ValueEquals(s);
    public double GetTotalEmissions => Value.GetProperty(TotalEmissions).GetProperty("value").GetDouble();
}
