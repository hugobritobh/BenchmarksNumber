using BenchmarkDotNet.Running;
using System;
using System.Threading.Tasks;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<IsNumberBenchmark>();
        }
    }

  
}

