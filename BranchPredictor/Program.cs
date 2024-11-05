using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace BranchPredictor;

public class SummarizeBenchmark
{
    private int[] orderedArray = new int[N];
    private int[] unorderedArray = new int[N];
    private const int N = 100_000;

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random();
        for (var i = 0; i < N; i++) 
            orderedArray[i] = (i % 3 != 0) ? i * 2 : 2 * i + 1;

        unorderedArray = orderedArray.OrderBy(_ => random.Next()).ToArray();
    }

    [Benchmark]
    public int Ordered()
    {
        return GetEvensCount(orderedArray);
    }

    [Benchmark]
    public int Unordered()
    {
        return GetEvensCount(unorderedArray);
    }

    [Benchmark]
    public int OrderedNoIf()
    {
        return GetEvensCountNoIf(orderedArray);
    }

    [Benchmark]
    public int UnorderedNoIf()
    {
        return GetEvensCountNoIf(unorderedArray);
    }

    public static int GetEvensCount(int[] arr)
    {
        var evens = 0;
        for (var i = 0; i < arr.Length; i++)
            if (arr[i] % 2 != 0)
                evens++;

        return evens;
    }

    public static int GetEvensCountNoIf(int[] arr)
    {
        var evens = 0;
        for (var i = 0; i < arr.Length; i++)
            evens += (arr[i] % 2);

        return evens;
    }
}

public static class Program
{
    public static void Main() => BenchmarkRunner.Run<SummarizeBenchmark>();
}