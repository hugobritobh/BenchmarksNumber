using BenchmarkDotNet.Attributes;

namespace BenchmarksNumber
{
    [RankColumn]
    [MemoryDiagnoser]
    public class IsNumberBenchmark
    {
        private string _input = ".1#2%3 4 Ä5 6-7ç8,9>0";

        [Benchmark]
        public int IF_Compare09()
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

        //[Benchmark]
        //public int IF_Substract()
        //{
        //    int number = 0;
        //    foreach (char value in _input)
        //    {
        //        if ((value - '0') <= 9)
        //            number++;
        //    }

        //    return number;
        //}

        [Benchmark]
        public int Switch_Statement()
        {
            int number = 0;
            foreach (char value in _input)
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
                        number++;
                        break;
                }
            }
            return number;
        }
    }
}
