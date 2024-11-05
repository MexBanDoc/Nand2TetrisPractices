using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CachesMisses;

public class SummarizeBenchmark
{
    private const int N = 10;
    private readonly int[,] array = new int[N,N];
    // private const int N = 100;
    // private const int N = 200;
    // private const int N = 300;
    // private const int N = 350;
    // private const int N = 500;
    // private const int N = 1000;
    // private const int N = 10000;

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random();
        for (var i = 0; i < N; i++)
        for (var j = 0; j < N; j++)
            array[i, j] = random.Next();
    }

    [Benchmark]
    public int Row()
    {
        return GetByRow(array);
    }

    [Benchmark]
    public int Column()
    {
        return GetByColumn(array);
    }

    private static int GetByRow(int[,] arr)
    {
        var sum = 0;
        for (var x = 0; x < N; x++)
        for (var y = 0; y < N; y++)
            sum += arr[x, y];
        return sum;
    }

    private static int GetByColumn(int[,] arr)
    {
        var sum = 0;
        for (var x = 0; x < N; x++)
        for (var y = 0; y < N; y++)
            sum += arr[y, x];
        return sum;
    }
}

public static class Program
{
    public static void Main()
    {
        BenchmarkRunner.Run<SummarizeBenchmark>();
    }
}