// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using HashBenchmark;

Console.WriteLine("Hello, World!");
Console.WriteLine("Running Hash Algorithm Benchmarks...");
var summary = BenchmarkRunner.Run<HashBenchmarks>();
Console.WriteLine("Benchmark completed!");
