using BenchmarkDotNet.Running;

namespace MemoryCavheBenchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MyMemoryCache>();
        }
    }
}
