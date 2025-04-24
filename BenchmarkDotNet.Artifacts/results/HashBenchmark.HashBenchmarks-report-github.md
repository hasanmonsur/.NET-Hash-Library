```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3775)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.102
  [Host]     : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2


```
| Method              | Mean      | Error     | StdDev    | Rank | Gen0   | Allocated |
|-------------------- |----------:|----------:|----------:|-----:|-------:|----------:|
| Sha256Hash          | 974.25 ns | 26.882 ns | 78.417 ns |    6 | 0.0849 |     400 B |
| XxHash64            |  24.66 ns |  0.515 ns |  1.493 ns |    1 |      - |         - |
| Blake3Hash          | 167.82 ns |  3.313 ns |  7.679 ns |    5 | 0.0322 |     152 B |
| BuiltInXxHash32     |  42.81 ns |  1.454 ns |  4.241 ns |    2 | 0.0153 |      72 B |
| XxHash64AsString    |  54.95 ns |  1.415 ns |  4.061 ns |    3 | 0.0187 |      88 B |
| XxHash32Alternative |  86.33 ns |  1.745 ns |  3.718 ns |    4 | 0.0221 |     104 B |
