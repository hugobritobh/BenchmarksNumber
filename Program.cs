using BenchmarkDotNet.Running;

namespace BenchmarksNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<IsNumberBenchmark>();
        }
    }
}