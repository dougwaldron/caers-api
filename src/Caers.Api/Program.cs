using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Caers.Api;
using System.Diagnostics.CodeAnalysis;

_ = BenchmarkRunner.Run<JsonParsingBenchmarks>();

[SuppressMessage("Design", "CA1050:Declare types in namespaces")]
[SuppressMessage("Performance", "CA1822:Mark members as static")]
[SuppressMessage("SonarLint", "S3903:Types should be defined in named namespaces")]
[MemoryDiagnoser]
public class JsonParsingBenchmarks
{
    private static readonly string EmissionsReportJson = File.ReadAllText(@"SampleReport\CAERS_ExampleFile_v1.0.json");

    [Benchmark]
    public double GetCoEmissionsUsingCorvusJson() => SumCoEmissions.UsingCorvusJson(EmissionsReportJson);

    [Benchmark]
    public double GetCoEmissionsUsingSystemJson() => SumCoEmissions.UsingSystemJson(EmissionsReportJson);

    [Benchmark]
    public double GetCoEmissionsUsingElementTypes() => SumCoEmissions.UsingElementTypes(EmissionsReportJson);
}
