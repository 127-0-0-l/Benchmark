using System;
using clr_via_cs;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    class Program
    {
        static void Main()
        {
            BenchmarkRunner.Run<MyBenchmark>();
        }
    }

    [MemoryDiagnoser]
    [RankColumn]
    public class MyBenchmark
    {
        [Benchmark]
        public void TestNoExtensionMethod()
        {
            string str = new S().M1("string", "string", "string", "string", "string");
        }

        [Benchmark]
        public void TestExtensionMethod()
        {
            string str = new S().M2("string", "string", "string", "string", "string");
        }
    }
}
