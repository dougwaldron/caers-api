using Caers.Api.SchemaEntities;
using System.Diagnostics;
using System.Globalization;
using System.Text.Json;

var emissionsReportJson = await File.ReadAllTextAsync(@"SampleReport\CAERS_ExampleFile_v1.0.json");

Console.WriteLine(UseSystemJson(emissionsReportJson));
Console.WriteLine(UseCorvusJson(emissionsReportJson));
Console.WriteLine("---");

Profile("1 System", 2000, () => UseSystemJson(emissionsReportJson));
Profile("2 System", 2000, () => UseSystemJson(emissionsReportJson));
Profile("3 System", 2000, () => UseSystemJson(emissionsReportJson));
Profile("1 Corvus", 2000, () => UseCorvusJson(emissionsReportJson));
Profile("2 Corvus", 2000, () => UseCorvusJson(emissionsReportJson));
Profile("3 Corvus", 2000, () => UseCorvusJson(emissionsReportJson));

return;

double UseCorvusJson(string s)
{
    return EmissionsReport.Parse(s)
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
}

double UseSystemJson(string s)
{
    return JsonDocument.Parse(s).RootElement
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
}

static void Profile(string description, int iterations, Action func)
{
    // From: https://stackoverflow.com/a/1048708/212978

    //Run at highest priority to minimize fluctuations caused by other processes/threads
    Process.GetCurrentProcess().PriorityClass = ProcessPriorityClass.High;
    Thread.CurrentThread.Priority = ThreadPriority.Highest;

    // warm up 
    func();

    var watch = new Stopwatch();

    // clean up
    GC.Collect();
    GC.WaitForPendingFinalizers();
    GC.Collect();

    watch.Start();
    for (var i = 0; i < iterations; i++)
    {
        func();
    }

    watch.Stop();

    Console.WriteLine(
        $"{description} -> {(watch.Elapsed.TotalMilliseconds / iterations).ToString("F3", CultureInfo.InvariantCulture)}");
}
