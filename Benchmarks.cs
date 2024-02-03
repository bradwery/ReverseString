using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Reports;

namespace ReverseStringDemo;

[MemoryDiagnoser(false)]
[Config(typeof(StyleConfig))]
public class Benchmarks
{
    private readonly string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!";

    [Benchmark(Baseline = true)]
    public void ArrayReverse()
    {
        ReverseString.ArrayReverse(s);
    }

    [Benchmark]
    public void LinqReverse()
    {
        ReverseString.LinqReverse(s);
    }

    [Benchmark]
    public void UsingRecursion()
    {
        ReverseString.UsingRecursion(s);
    }

    [Benchmark]
    public void MeetInTheMiddle()
    {
        ReverseString.MeetInTheMiddle(s);
    }

    [Benchmark]
    public void UsingSpan()
    {
        ReverseString.UsingSpan(s);
    }

}

public class StyleConfig : ManualConfig
{
    public StyleConfig()
    {
        SummaryStyle = SummaryStyle.Default.WithRatioStyle(RatioStyle.Trend);
    }
}
