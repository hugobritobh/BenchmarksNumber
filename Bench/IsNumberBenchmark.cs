using BenchmarkDotNet.Attributes;
using System.Runtime.CompilerServices;

namespace Benchmarks
{
    [RankColumn]
    [MemoryDiagnoser]
    public class IsNumberBenchmark
    {
        private string _input = "a1b2c3d4e5f6g7h8i9j0";

        [Benchmark]
        public int IsDigit()
        {
            int number = 0;
            foreach (char value in _input)
            {
                if (char.IsDigit(value))
                    number++;
            }
            return number;
        }

        [Benchmark]
        public int IsNumberMethodNoInlining()
        {
            int number = 0;
            foreach(char value in _input)
            {
                if(IsNumber1(value)) 
                    number++;
            }
            return number;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static bool IsNumber1(char value)
        {
            return value >= '0' && value <= '9';
        }

        [Benchmark]
        public int IsNumberMethodAggressiveOptimization()
        {
            int number = 0;
            foreach (char value in _input)
            {
                if (IsNumber2(value))
                    number++;
            }
            return number;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static bool IsNumber2(char value)
        {
            return value >= '0' && value <= '9';
        }

        [Benchmark]
        public int IsNumber()
        {
            int number = 0;
            foreach (char value in _input)
            {
                if (value >= '0' && value <= '9')
                    number++;
            }
            return number;
        }

        [Benchmark]
        public int SwitchStatement()
        {
            int number = 0;
            foreach(char value in _input)
            {
                switch(value)
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        number++;
                        break;
                }
            }
            return number;
        }

        [Benchmark]
        public int SwitchStatementNoInlining()
        {
            int number = 0;
            foreach (char value in _input)
            {
                if (IsNumberSwitch1(value))
                    number++;
            }
            return number;
        }

        [MethodImpl(MethodImplOptions.NoInlining)]
        private static bool IsNumberSwitch1(char value)
        {
            switch (value)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return true;                    
            }

            return false;
        }


        [Benchmark]
        public int SwitchStatementAggressiveOptimization()
        {
            int number = 0;
            foreach (char value in _input)
            {
                if (IsNumberSwitch2(value))
                    number++;
            }
            return number;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private static bool IsNumberSwitch2(char value)
        {
            switch (value)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return true;
            }

            return false;
        }
    }
}
