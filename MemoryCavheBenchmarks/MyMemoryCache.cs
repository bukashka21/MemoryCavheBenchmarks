using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryCavheBenchmarks
{
    public class MyMemoryCache
    {
        [Params(100,1000, 10000, 50000, 100000, 1000000)]
        public int cacheSize;
        public Key Key = new Key(1000, 2026, 13);
        public Key AtStartKey = new Key(2000, 2027, 14);
        public Key AtEndKey = new Key(3000, 2028, 15);
        public IMemoryCache cache;

        [GlobalSetup]
        public void BuildData()
        {
            cache = new MemoryCache(new MemoryCacheOptions());
            var r = new Random();
            cache.Set(AtStartKey, 55.6677);
            for (int i = 0; i < cacheSize/ 2; i++)
            {
                var key = new Key(i + 2, (short)r.Next(2023, 2025), (short)r.Next(1, 12));
                var value = r.Next(500, 9999);
                cache.Set(key, value / 100);
            }
            cache.Set(Key, 55.6677);
            for (int i = 0; i < cacheSize / 2; i++)
            {
                var key = new Key(i + 2, (short)r.Next(2023, 2025), (short)r.Next(1, 12));
                var value = r.Next(500, 9999);
                cache.Set(key, value / 100);
            }
            cache.Set(AtEndKey, 55.6677);
        }

        [Benchmark]
        public decimal GetValue()
        {
            cache.TryGetValue(Key,out decimal value);
            return value;
        }

        [Benchmark]
        public decimal GetAtStartValue()
        {
            cache.TryGetValue(AtStartKey, out decimal value);
            return value;
        }

        [Benchmark]
        public decimal GetAtEndValue()
        {
            cache.TryGetValue(AtEndKey, out decimal value);
            return value;
        }
    }

    public class Key
    {
        public int Id { get; set; }
        public short Year { get; set; }
        public short Month { get; set; }

        public override bool Equals(object obj)
        {
            if(obj is null)
            {
                return false;
            }
            var k = obj as Key;
            if(k is null)
            {
                return false;
            }
            return Id == k.Id && Year == k.Year && Month == k.Month;
        }

        public Key(int id, short year, short month)
        {
            Id = id;
            Year = year;
            Month = month;
        }
        


    }
}
