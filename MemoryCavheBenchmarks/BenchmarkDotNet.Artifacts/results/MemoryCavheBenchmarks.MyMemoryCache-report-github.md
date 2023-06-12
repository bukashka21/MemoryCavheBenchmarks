``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2604/22H2/2022Update)
Intel Celeron CPU 1005M 1.90GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT SSE4.2
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT SSE4.2


```
|   Method | cacheSize |     Mean |   Error |  StdDev |
|--------- |---------- |---------:|--------:|--------:|
| **GetValue** |       **100** | **207.1 ns** | **0.21 ns** | **0.20 ns** |
| **GetValue** |      **1000** | **204.0 ns** | **0.20 ns** | **0.18 ns** |
| **GetValue** |     **10000** | **207.6 ns** | **0.12 ns** | **0.12 ns** |
| **GetValue** |     **50000** | **205.8 ns** | **0.42 ns** | **0.35 ns** |
| **GetValue** |    **100000** | **205.6 ns** | **0.10 ns** | **0.10 ns** |
| **GetValue** |   **1000000** | **208.0 ns** | **1.96 ns** | **1.83 ns** |
