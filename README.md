# BenchmarksNumber
## What is the best way to check if a character is a number?

Library BenchmarkDotNet was used and the results were compared. 

These results may differ depending on the processor architecture. So it’s good to run more tests on different environments and processors.

### I performed at different times and sometimes the result was not always the same. Here are the results:
In most results, the IsNumber and SwitchStatement method are in the top positions.

===============================================================================

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


|                                Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|                               IsDigit | 24.28 ns | 0.184 ns | 0.173 ns |    1 |     - |     - |     - |         - |
|              IsNumberMethodNoInlining | 54.08 ns | 0.603 ns | 0.564 ns |    4 |     - |     - |     - |         - |
|  IsNumberMethodAggressiveOptimization | 26.18 ns | 0.133 ns | 0.111 ns |    3 |     - |     - |     - |         - |
|                              IsNumber | 24.84 ns | 0.230 ns | 0.215 ns |    2 |     - |     - |     - |         - |
|                       SwitchStatement | 24.92 ns | 0.278 ns | 0.246 ns |    2 |     - |     - |     - |         - |
|             SwitchStatementNoInlining | 52.34 ns | 1.099 ns | 1.576 ns |    4 |     - |     - |     - |         - |
| SwitchStatementAggressiveOptimization | 53.56 ns | 1.093 ns | 0.912 ns |    4 |     - |     - |     - |         - |

===============================================================================

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


|                                Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|                               IsDigit | 30.45 ns | 0.600 ns | 0.617 ns |    4 |     - |     - |     - |         - |
|              IsNumberMethodNoInlining | 52.40 ns | 0.453 ns | 0.402 ns |    5 |     - |     - |     - |         - |
|  IsNumberMethodAggressiveOptimization | 25.78 ns | 0.167 ns | 0.148 ns |    2 |     - |     - |     - |         - |
|                              IsNumber | 26.79 ns | 0.559 ns | 0.965 ns |    3 |     - |     - |     - |         - |
|                       SwitchStatement | 24.95 ns | 0.180 ns | 0.141 ns |    1 |     - |     - |     - |         - |
|             SwitchStatementNoInlining | 52.58 ns | 1.094 ns | 1.534 ns |    5 |     - |     - |     - |         - |
| SwitchStatementAggressiveOptimization | 53.56 ns | 0.262 ns | 0.245 ns |    5 |     - |     - |     - |         - |


===============================================================================

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

|                                Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|                               IsDigit | 30.61 ns | 0.299 ns | 0.280 ns |    3 |     - |     - |     - |         - |
|              IsNumberMethodNoInlining | 55.51 ns | 1.137 ns | 1.900 ns |    5 |     - |     - |     - |         - |
|  IsNumberMethodAggressiveOptimization | 27.89 ns | 0.642 ns | 1.830 ns |    2 |     - |     - |     - |         - |
|                              IsNumber | 25.16 ns | 0.254 ns | 0.238 ns |    1 |     - |     - |     - |         - |
|                       SwitchStatement | 25.37 ns | 0.479 ns | 0.374 ns |    1 |     - |     - |     - |         - |
|             SwitchStatementNoInlining | 64.64 ns | 1.107 ns | 0.924 ns |    6 |     - |     - |     - |         - |
| SwitchStatementAggressiveOptimization | 53.51 ns | 0.443 ns | 0.393 ns |    4 |     - |     - |     - |         - |


===============================================================================

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


|                                Method |     Mean |    Error |   StdDev |   Median | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |---------:|---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|                               IsDigit | 29.36 ns | 0.274 ns | 0.243 ns | 29.38 ns |    4 |     - |     - |     - |         - |
|              IsNumberMethodNoInlining | 54.79 ns | 0.539 ns | 0.504 ns | 54.67 ns |    5 |     - |     - |     - |         - |
|  IsNumberMethodAggressiveOptimization | 26.96 ns | 0.552 ns | 1.465 ns | 26.22 ns |    3 |     - |     - |     - |         - |
|                              IsNumber | 19.58 ns | 0.218 ns | 0.204 ns | 19.59 ns |    1 |     - |     - |     - |         - |
|                       SwitchStatement | 25.08 ns | 0.057 ns | 0.048 ns | 25.08 ns |    2 |     - |     - |     - |         - |
|             SwitchStatementNoInlining | 63.98 ns | 0.704 ns | 0.624 ns | 63.90 ns |    7 |     - |     - |     - |         - |
| SwitchStatementAggressiveOptimization | 60.64 ns | 0.628 ns | 0.588 ns | 60.49 ns |    6 |     - |     - |     - |         - |

===============================================================================

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


|                                Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|                               IsDigit | 23.91 ns | 0.490 ns | 0.458 ns |    2 |     - |     - |     - |         - |
|              IsNumberMethodNoInlining | 60.43 ns | 0.457 ns | 0.428 ns |    5 |     - |     - |     - |         - |
|  IsNumberMethodAggressiveOptimization | 25.33 ns | 0.266 ns | 0.248 ns |    3 |     - |     - |     - |         - |
|                              IsNumber | 14.95 ns | 0.134 ns | 0.119 ns |    1 |     - |     - |     - |         - |
|                       SwitchStatement | 14.94 ns | 0.122 ns | 0.109 ns |    1 |     - |     - |     - |         - |
|             SwitchStatementNoInlining | 52.95 ns | 1.078 ns | 1.154 ns |    4 |     - |     - |     - |         - |
| SwitchStatementAggressiveOptimization | 63.76 ns | 0.812 ns | 0.720 ns |    6 |     - |     - |     - |         - |


===============================================================================

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


|                                Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|                               IsDigit | 30.28 ns | 0.270 ns | 0.239 ns |    3 |     - |     - |     - |         - |
|              IsNumberMethodNoInlining | 54.73 ns | 0.580 ns | 0.484 ns |    4 |     - |     - |     - |         - |
|  IsNumberMethodAggressiveOptimization | 26.42 ns | 0.218 ns | 0.204 ns |    2 |     - |     - |     - |         - |
|                              IsNumber | 24.92 ns | 0.109 ns | 0.097 ns |    1 |     - |     - |     - |         - |
|                       SwitchStatement | 25.04 ns | 0.230 ns | 0.192 ns |    1 |     - |     - |     - |         - |
|             SwitchStatementNoInlining | 64.29 ns | 0.608 ns | 0.568 ns |    6 |     - |     - |     - |         - |
| SwitchStatementAggressiveOptimization | 61.50 ns | 0.593 ns | 0.555 ns |    5 |     - |     - |     - |         - |


===============================================================================

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


|                                Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|                               IsDigit | 31.78 ns | 0.334 ns | 0.261 ns |    3 |     - |     - |     - |         - |
|              IsNumberMethodNoInlining | 57.15 ns | 1.169 ns | 1.200 ns |    5 |     - |     - |     - |         - |
|  IsNumberMethodAggressiveOptimization | 27.14 ns | 0.389 ns | 0.363 ns |    2 |     - |     - |     - |         - |
|                              IsNumber | 16.16 ns | 0.307 ns | 0.287 ns |    1 |     - |     - |     - |         - |
|                       SwitchStatement | 16.16 ns | 0.293 ns | 0.245 ns |    1 |     - |     - |     - |         - |
|             SwitchStatementNoInlining | 50.76 ns | 0.891 ns | 0.833 ns |    4 |     - |     - |     - |         - |
| SwitchStatementAggressiveOptimization | 67.51 ns | 0.463 ns | 0.386 ns |    6 |     - |     - |     - |         - |
 
