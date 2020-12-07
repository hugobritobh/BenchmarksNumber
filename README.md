# BenchmarksNumber
## What is the best way to check if a character is a number?

Library BenchmarkDotNet was used and the results were compared. 

### Methodology
1) Changing the order of methods
2) Published with target Win-x64 and RTR (Ready to Run)
3) Collect the results
4) Repeated the steps

### Results
These results may differ depending on the processor architecture. So it’s good to run more tests on different environments and processors.

Some methods had different results depending on the position they were in. I believe that this difference may be something related to HotPath or Processor Cache.

The method that always kept the same result was the IF_Substract

========================================================================
#### Windows 10
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT

|           Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|     IF_Substract | 19.40 ns | 0.382 ns | 0.319 ns |    1 |     - |     - |     - |         - |
|     IF_Compare09 | 19.27 ns | 0.126 ns | 0.112 ns |    1 |     - |     - |     - |         - |
| Switch_Statement | 32.15 ns | 0.356 ns | 0.333 ns |    2 |     - |     - |     - |         - |
|          IsDigit | 38.79 ns | 0.716 ns | 0.635 ns |    3 |     - |     - |     - |         - |

==================================================

|           Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
| Switch_Statement | 21.98 ns | 0.174 ns | 0.154 ns |    2 |     - |     - |     - |         - |
|     IF_Compare09 | 32.02 ns | 0.453 ns | 0.424 ns |    3 |     - |     - |     - |         - |
|     IF_Substract | 19.15 ns | 0.163 ns | 0.145 ns |    1 |     - |     - |     - |         - |
|          IsDigit | 37.92 ns | 0.438 ns | 0.388 ns |    4 |     - |     - |     - |         - |

=================================================

|           Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|          IsDigit | 31.16 ns | 0.418 ns | 0.370 ns |    2 |     - |     - |     - |         - |
|     IF_Substract | 19.22 ns | 0.141 ns | 0.132 ns |    1 |     - |     - |     - |         - |
|     IF_Compare09 | 32.39 ns | 0.638 ns | 0.566 ns |    3 |     - |     - |     - |         - |
| Switch_Statement | 19.18 ns | 0.222 ns | 0.197 ns |    1 |     - |     - |     - |         - |

==================================================


|           Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
| Switch_Statement | 22.25 ns | 0.481 ns | 0.572 ns |    2 |     - |     - |     - |         - |
|     IF_Compare09 | 31.96 ns | 0.287 ns | 0.269 ns |    3 |     - |     - |     - |         - |
|          IsDigit | 38.22 ns | 0.455 ns | 0.426 ns |    4 |     - |     - |     - |         - |
|     IF_Substract | 19.40 ns | 0.369 ns | 0.288 ns |    1 |     - |     - |     - |         - |

 ####  Ubuntu 20.04 (windows - WSL2)

BenchmarkDotNet=v0.12.1, OS=ubuntu 20.04
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.100
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  DefaultJob : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT


|           Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
| Switch_Statement | 21.09 ns | 0.467 ns | 0.713 ns |    2 |     - |     - |     - |         - |
|     IF_Compare09 | 20.56 ns | 0.233 ns | 0.195 ns |    1 |     - |     - |     - |         - |
|          IsDigit | 45.13 ns | 0.588 ns | 0.550 ns |    3 |     - |     - |     - |         - |
|     IF_Substract | 21.24 ns | 0.244 ns | 0.228 ns |    2 |     - |     - |     - |         - |

==================================================

|           Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|     IF_Substract | 20.67 ns | 0.420 ns | 0.876 ns |    1 |     - |     - |     - |         - |
|          IsDigit | 40.78 ns | 0.784 ns | 1.311 ns |    2 |     - |     - |     - |         - |
|     IF_Compare09 | 20.51 ns | 0.371 ns | 0.310 ns |    1 |     - |     - |     - |         - |
| Switch_Statement | 20.12 ns | 0.257 ns | 0.227 ns |    1 |     - |     - |     - |         - |

==================================================

|           Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|          IsDigit | 42.31 ns | 0.881 ns | 1.235 ns |    2 |     - |     - |     - |         - |
| Switch_Statement | 21.20 ns | 0.268 ns | 0.251 ns |    1 |     - |     - |     - |         - |
|     IF_Compare09 | 21.16 ns | 0.156 ns | 0.153 ns |    1 |     - |     - |     - |         - |
|     IF_Substract | 21.14 ns | 0.319 ns | 0.298 ns |    1 |     - |     - |     - |         - |

==================================================

|           Method |     Mean |    Error |   StdDev | Rank | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------- |---------:|---------:|---------:|-----:|------:|------:|------:|----------:|
|     IF_Compare09 | 21.49 ns | 0.415 ns | 0.770 ns |    2 |     - |     - |     - |         - |
|          IsDigit | 42.32 ns | 0.676 ns | 0.528 ns |    3 |     - |     - |     - |         - |
|     IF_Substract | 21.10 ns | 0.148 ns | 0.116 ns |    1 |     - |     - |     - |         - |
| Switch_Statement | 21.64 ns | 0.384 ns | 0.341 ns |    2 |     - |     - |     - |         - |
