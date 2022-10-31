using BenchmarkDotNet.Attributes;

namespace Benchmarkd;

public class MathMaxBenchmark
{
    private int left;
    private int right;
    private static readonly Random rnd = new();

    public MathMaxBenchmark()
    {
        left = rnd.Next(-10000, 10000);
        right = rnd.Next(-10000, 10000);
    }

    [Benchmark]
    public int BitShift() => MaxBitShift(left, right);

    [Benchmark]
    public int MathMax() => Math.Max(left, right);

    private int MaxBitShift(int a, int b)
    {
        var diff = a - b;
        var dsgn = diff >> 31;
        return a - (diff & dsgn);
    }
}