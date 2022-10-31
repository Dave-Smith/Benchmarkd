using Benchmarkd;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<MathMaxBenchmark>();

