``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2604/22H2/2022Update)
Intel Celeron CPU 1005M 1.90GHz, 1 CPU, 2 logical and 2 physical cores
.NET SDK=5.0.301
  [Host]     : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT SSE4.2
  DefaultJob : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT SSE4.2


```
| Method |     Mean |    Error |   StdDev |
|------- |---------:|---------:|---------:|
| Sha256 | 87.99 μs | 0.524 μs | 0.490 μs |
|    Md5 | 36.45 μs | 0.054 μs | 0.051 μs |
