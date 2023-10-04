using Caers.Api.Elements;
using Caers.Api.SchemaEntities;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;

namespace Caers.Api;

public static class SumCoEmissions
{
    public static double UsingCorvusJson(string s) =>
        EmissionsReport.Parse(s)
            .FacilitySite.EnumerateArray().First()
            .EmissionsUnits.EnumerateArray()
            .SelectMany(emissionsUnit => emissionsUnit.EmissionsProcesses.EnumerateArray()
                .SelectMany(emissionsProcess => emissionsProcess.ReportingPeriods.EnumerateArray()
                    .SelectMany(reportingPeriod => reportingPeriod.Emissions.EnumerateArray()
                        .Where(emission => emission.PollutantCode.PollutantCode.Equals("CO"))
                        .Select(emission => (double)emission.TotalEmissions.Value)
                    )
                )
            ).Sum();

    public static double UsingSystemJson(string s) =>
        JsonDocument.Parse(s).RootElement
            .GetProperty("facilitySite").EnumerateArray().First()
            .GetProperty("emissionsUnits").EnumerateArray()
            .SelectMany(emissionsUnit => emissionsUnit.GetProperty("emissionsProcesses").EnumerateArray()
                .SelectMany(emissionsProcess => emissionsProcess.GetProperty("reportingPeriods").EnumerateArray()
                    .SelectMany(reportingPeriod => reportingPeriod.GetProperty("emissions").EnumerateArray()
                        .Where(emission =>
                            emission.GetProperty("pollutantCode").GetProperty("pollutantCode").GetString() == "CO")
                        .Select(emission => emission.GetProperty("totalEmissions").GetProperty("value").GetDouble())
                    )
                )
            ).Sum();

    public static double UsingElementTypes(string s) =>
        new Report(JsonDocument.Parse(s).RootElement)
            .GetFirstFacility()
            .GetEmissionsUnits()
            .Values.SelectMany(emissionsUnit => emissionsUnit.GetEmissionsProcesses()
                .Values.SelectMany(emissionsProcess => emissionsProcess.GetReportingPeriods()
                    .Values.SelectMany(reportingPeriod => reportingPeriod.GetEmissions()
                        .Values.Where(emission => emission.GetPollutantCode == "CO")
                        .Select(emission => emission.GetTotalEmissions)
                    )
                )
            ).Sum();
}
