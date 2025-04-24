using BenchmarkDotNet.Attributes;
using System.Security.Cryptography;
using System.Text;
using Blake3;
using System.IO.Hashing;

namespace HashBenchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class HashBenchmarks
    {
        private readonly byte[] _sampleData;

        public HashBenchmarks()
        {
            _sampleData = Encoding.UTF8.GetBytes("This is a sample text for hashing benchmark in .NET 9");
        }

        [Benchmark]
        public string Sha256Hash()
        {
            using var sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(_sampleData);
            return Convert.ToHexString(hashBytes);
        }

        [Benchmark]
        public ulong XxHash64()
        {
            return System.IO.Hashing.XxHash64.HashToUInt64(_sampleData);
        }

        [Benchmark]
        public string Blake3Hash()
        {
            return Hasher.Hash(_sampleData).ToString();
        }

        [Benchmark]
        public string BuiltInXxHash32()
        {
            var hashBytes = new byte[4];
            XxHash32.Hash(_sampleData, hashBytes);
            return Convert.ToHexString(hashBytes);
        }

        [Benchmark]
        public string XxHash64AsString()
        {
            var hashBytes = new byte[8];
            System.IO.Hashing.XxHash64.Hash(_sampleData, hashBytes);
            return Convert.ToHexString(hashBytes);
        }

        [Benchmark]
        public uint XxHash32Alternative()
        {
            var hash = new XxHash32();
            hash.Append(_sampleData);
            return hash.GetCurrentHashAsUInt32();
        }
    }
}
