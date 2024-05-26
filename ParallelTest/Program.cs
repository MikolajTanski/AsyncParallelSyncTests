using System;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        BenchmarkRunner.Run<Benchmarks>();
    }
}

/// <summary>
/// obliczenie sumy kwadratow dla 100 i 1 000 000
/// </summary>
public class Benchmarks
{
    private const int SmallN = 100;
    private const int LargeN = 1000000;

    // Synchroniczne małe obliczenia
    [Benchmark]
    public int SyncSmallCalc()
    {
        int sum = 0;
        for (int i = 1; i <= SmallN; i++)
        {
            sum += i;
        }
        return sum;
    }

    // Asynchroniczne małe obliczenia
    [Benchmark]
    public async Task<int> AsyncSmallCalc()
    {
        return await Task.Run(() =>
        {
            int sum = 0;
            for (int i = 1; i <= SmallN; i++)
            {
                sum += i;
            }
            return sum;
        });
    }

    // Równoległe małe obliczenia
    [Benchmark]
    public int ParallelSmallCalc()
    {
        int sum = 0;
        Parallel.For(1, SmallN + 1, () => 0, (i, state, localSum) =>
        {
            return localSum + i;
        },
        localSum => Interlocked.Add(ref sum, localSum));
        return sum;
    }

    // Synchroniczne duże obliczenia
    [Benchmark]
    public double SyncLargeCalc()
    {
        double sum = 0;
        for (int i = 1; i <= LargeN; i++)
        {
            sum += Math.Pow(i, 2);
        }
        return sum;
    }

    // Asynchroniczne duże obliczenia
    [Benchmark]
    public async Task<double> AsyncLargeCalc()
    {
        return await Task.Run(() =>
        {
            double sum = 0;
            for (int i = 1; i <= LargeN; i++)
            {
                sum += Math.Pow(i, 2);
            }
            return sum;
        });
    }

    // Równoległe duże obliczenia
    [Benchmark]
    public double ParallelLargeCalc()
    {
        double sum = 0;
        Parallel.For(1L, (long)LargeN + 1, () => 0.0, (i, state, localSum) =>
        {
            return localSum + Math.Pow(i, 2);
        },
        localSum => { lock (new Object()) { sum += localSum; } });
        return sum;
    }
}
