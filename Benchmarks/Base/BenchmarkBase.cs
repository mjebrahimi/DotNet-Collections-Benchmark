using BenchmarkDotNet.Attributes;
using Utilities;

namespace Benchmarks;

#region Benchmark Types
//Type[] benchmarkTypes = [
//    typeof(InitializeBenchmark<int>),
//    typeof(InitializeBenchmark<string>),
//    typeof(InitializeBenchmark<StructInts>),
//    typeof(InitializeBenchmark<StructStrings>),
//    typeof(InitializeBenchmark<ClassInts>),
//    typeof(InitializeBenchmark<ClassStrings>),
//    typeof(InitializeBenchmark<RecordStructInts>),
//    typeof(InitializeBenchmark<RecordStructStrings>),
//    typeof(InitializeBenchmark<RecordClassInts>),
//    typeof(InitializeBenchmark<RecordClassStrings>),

//    typeof(ContainsBenchmark<int>),
//    typeof(ContainsBenchmark<string>),
//    typeof(ContainsBenchmark<StructInts>),
//    typeof(ContainsBenchmark<StructStrings>),
//    typeof(ContainsBenchmark<ClassInts>),
//    typeof(ContainsBenchmark<ClassStrings>),
//    typeof(ContainsBenchmark<RecordStructInts>),
//    typeof(ContainsBenchmark<RecordStructStrings>),
//    typeof(ContainsBenchmark<RecordClassInts>),
//    typeof(ContainsBenchmark<RecordClassStrings>),

//    typeof(TryGetValueBenchmark<int>),
//    typeof(TryGetValueBenchmark<string>),
//    typeof(TryGetValueBenchmark<StructInts>),
//    typeof(TryGetValueBenchmark<StructStrings>),
//    typeof(TryGetValueBenchmark<ClassInts>),
//    typeof(TryGetValueBenchmark<ClassStrings>),
//    typeof(TryGetValueBenchmark<RecordStructInts>),
//    typeof(TryGetValueBenchmark<RecordStructStrings>),
//    typeof(TryGetValueBenchmark<RecordClassInts>),
//    typeof(TryGetValueBenchmark<RecordClassStrings>),
//];
#endregion

[CategoriesColumn]
[MemoryDiagnoser(displayGenColumns: false)]
[Config(typeof(CustomConfig))]
#if RELEASE
[ShortRunJob]
//[SimpleJob(BenchmarkDotNet.Engines.RunStrategy.Throughput)]
#else
[MarkdownExporterAttribute.GitHub]
#endif
public class BenchmarkBase
{
    private const int stringLength = 10;
    private static readonly char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
    public static T[] GetRandomUniqueArray<T>(int length)
    {
        //DO NOT USE this Random as an instance/static property/field, to produce same values across different executions
        //Seeded random (use math numbers with high entropy for seed value such as: pi, e, or golden ratio
        var random = new Random(314159265);
        var hashSet = new HashSet<T>(length);

        if (typeof(T) == typeof(int))
        {
            while (hashSet.Count < length)
            {
                var item = random.Next();
                hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(string))
        {
            while (hashSet.Count < length)
            {
                var item = new string(random.GetItems(chars, stringLength));
                hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(StructInts))
        {
            while (hashSet.Count < length)
            {
                var item = new StructInts
                {
                    Prop1 = random.Next(),
                    Prop2 = random.Next(),
                    Prop3 = random.Next()
                };
                hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(StructStrings))
        {
            while (hashSet.Count < length)
            {
                var item = new StructStrings
                {
                    Prop1 = new string(random.GetItems(chars, stringLength)),
                    Prop2 = new string(random.GetItems(chars, stringLength)),
                    Prop3 = new string(random.GetItems(chars, stringLength))
                };
                hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(ClassInts))
        {
            while (hashSet.Count < length)
            {
                var item = new ClassInts
                {
                    Prop1 = random.Next(),
                    Prop2 = random.Next(),
                    Prop3 = random.Next()
                };
                hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(ClassStrings))
        {
            while (hashSet.Count < length)
            {
                var item = new ClassStrings
                {
                    Prop1 = new string(random.GetItems(chars, stringLength)),
                    Prop2 = new string(random.GetItems(chars, stringLength)),
                    Prop3 = new string(random.GetItems(chars, stringLength))
                };
                hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(RecordStructInts))
        {
            while (hashSet.Count < length)
            {
                var item = new RecordStructInts(
                    Prop1: random.Next(),
                    Prop2: random.Next(),
                    Prop3: random.Next()
                );
                hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(RecordStructStrings))
        {
            while (hashSet.Count < length)
            {
                var item = new RecordStructStrings(
                    Prop1: new string(random.GetItems(chars, stringLength)),
                    Prop2: new string(random.GetItems(chars, stringLength)),
                    Prop3: new string(random.GetItems(chars, stringLength))
                );
                hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(RecordClassInts))
        {
            while (hashSet.Count < length)
            {
                var item = new RecordClassInts(
                    Prop1: random.Next(),
                    Prop2: random.Next(),
                    Prop3: random.Next()
                );
                hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(RecordClassStrings))
        {
            while (hashSet.Count < length)
            {
                var item = new RecordClassStrings(
                    Prop1: new string(random.GetItems(chars, stringLength)),
                    Prop2: new string(random.GetItems(chars, stringLength)),
                    Prop3: new string(random.GetItems(chars, stringLength))
                );
                hashSet.Add((dynamic)item);
            }
        }
        else
        {
            throw new InvalidOperationException($"Type {typeof(T).Name} is not supported.");
        }

        return hashSet.ToArray();
    }


    //Call this method exactly after GetRandomUniqueArray() method (before any sorting or modification)
    public static T[] GetExistedItemsToFind<T>(T[] array)
    {
        var sortedArray = array.Order().ToArray();

        var items1 = GetFirstMiddleLast(array);
        var items2 = GetFirstMiddleLast(sortedArray);

        var items3 = GetRandomItems(array);
        var items4 = GetRandomItems(sortedArray);

        T[] items = [
            .. items1,
            .. items2,
            .. items3,
            .. items4];

        //DO NOT USE Distinct() because it unfairly results in different item count for different collections
        return items.ToArray().Sort();

        static T[] GetFirstMiddleLast(T[] array)
        {
            var first = array[0];
            //var q1 = array[count / 4];
            var middle = array[array.Length / 2];
            //var q3 = array[^(count / 4)];
            var last = array[^1];
            return [first, /*q1,*/ middle, /*q3,*/ last];
        }

        static T[] GetRandomItems(T[] array)
        {
            //DO NOT USE this Random as an instance/static property/field, to produce same values across different executions
            //Seeded random (use math numbers with high entropy for seed value such as: pi, e, or golden ratio
            var random = new Random(314159265);
            return random.GetItems(array, 3);
        }
    }

    //Call this method exactly after GetRandomUniqueArray() method (before any sorting or modification)
    public static T[] GetNotExistedItemsToFind<T>(T[] array)
    {
        const int length = 12;
        //DO NOT USE this Random as an instance/static property/field, to produce same values across different executions
        //Seeded random (use math numbers with high entropy for seed value such as: pi, e, or golden ratio
        var random = new Random(271828182);
        var hashSet = new HashSet<T>(length);
        var items = array.ToHashSet();

        if (typeof(T) == typeof(int))
        {
            while (hashSet.Count < length)
            {
                var item = random.Next();
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(string))
        {
            while (hashSet.Count < length)
            {
                var item = new string(random.GetItems(chars, stringLength));
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(StructInts))
        {
            while (hashSet.Count < length)
            {
                var item = new StructInts
                {
                    Prop1 = random.Next(),
                    Prop2 = random.Next(),
                    Prop3 = random.Next()
                };
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(StructStrings))
        {
            while (hashSet.Count < length)
            {
                var item = new StructStrings
                {
                    Prop1 = new string(random.GetItems(chars, stringLength)),
                    Prop2 = new string(random.GetItems(chars, stringLength)),
                    Prop3 = new string(random.GetItems(chars, stringLength))
                };
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(ClassInts))
        {
            while (hashSet.Count < length)
            {
                var item = new ClassInts
                {
                    Prop1 = random.Next(),
                    Prop2 = random.Next(),
                    Prop3 = random.Next()
                };
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(ClassStrings))
        {
            while (hashSet.Count < length)
            {
                var item = new ClassStrings
                {
                    Prop1 = new string(random.GetItems(chars, stringLength)),
                    Prop2 = new string(random.GetItems(chars, stringLength)),
                    Prop3 = new string(random.GetItems(chars, stringLength))
                };
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(RecordStructInts))
        {
            while (hashSet.Count < length)
            {
                var item = new RecordStructInts(
                    Prop1: random.Next(),
                    Prop2: random.Next(),
                    Prop3: random.Next()
                );
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(RecordStructStrings))
        {
            while (hashSet.Count < length)
            {
                var item = new RecordStructStrings(
                    Prop1: new string(random.GetItems(chars, stringLength)),
                    Prop2: new string(random.GetItems(chars, stringLength)),
                    Prop3: new string(random.GetItems(chars, stringLength))
                );
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(RecordClassInts))
        {
            while (hashSet.Count < length)
            {
                var item = new RecordClassInts(
                    Prop1: random.Next(),
                    Prop2: random.Next(),
                    Prop3: random.Next()
                );
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else if (typeof(T) == typeof(RecordClassStrings))
        {
            while (hashSet.Count < length)
            {
                var item = new RecordClassStrings(
                    Prop1: new string(random.GetItems(chars, stringLength)),
                    Prop2: new string(random.GetItems(chars, stringLength)),
                    Prop3: new string(random.GetItems(chars, stringLength))
                );
                if (items.Contains((dynamic)item) is false)
                    hashSet.Add((dynamic)item);
            }
        }
        else
        {
            throw new InvalidOperationException($"Type {typeof(T).Name} is not supported.");
        }

        return hashSet.ToArray();
    }

    //private static T GetNotFoundValue<T>()
    //{
    //    dynamic value;
    //    if (typeof(T) == typeof(int))
    //    {
    //        value = 99999999;
    //    }
    //    else if (typeof(T) == typeof(string))
    //    {
    //        value = "AAAAAAAAAA";
    //    }
    //    else if (typeof(T) == typeof(StructInts))
    //    {
    //        value = new StructInts { Prop1 = 99999999, Prop2 = 99999999, Prop3 = 99999999 };
    //    }
    //    else if (typeof(T) == typeof(StructStrings))
    //    {
    //        value = new StructStrings { Prop1 = "AAAAAAAAAA", Prop2 = "AAAAAAAAAA", Prop3 = "AAAAAAAAAA" };
    //    }
    //    else if (typeof(T) == typeof(ClassInts))
    //    {
    //        value = new ClassInts { Prop1 = 99999999, Prop2 = 99999999, Prop3 = 99999999 };
    //    }
    //    else if (typeof(T) == typeof(ClassStrings))
    //    {
    //        value = new ClassStrings { Prop1 = "AAAAAAAAAA", Prop2 = "AAAAAAAAAA", Prop3 = "AAAAAAAAAA" };
    //    }
    //    else if (typeof(T) == typeof(RecordStructInts))
    //    {
    //        value = new RecordStructInts(Prop1: 99999999, Prop2: 99999999, Prop3: 99999999);
    //    }
    //    else if (typeof(T) == typeof(RecordStructStrings))
    //    {
    //        value = new RecordStructStrings(Prop1: "AAAAAAAAAA", Prop2: "AAAAAAAAAA", Prop3: "AAAAAAAAAA");
    //    }
    //    else if (typeof(T) == typeof(RecordClassInts))
    //    {
    //        value = new RecordClassInts(Prop1: 99999999, Prop2: 99999999, Prop3: 99999999);
    //    }
    //    else if (typeof(T) == typeof(RecordClassStrings))
    //    {
    //        value = new RecordClassStrings(Prop1: "AAAAAAAAAA", Prop2: "AAAAAAAAAA", Prop3: "AAAAAAAAAA");
    //    }
    //    else
    //    {
    //        throw new InvalidOperationException($"Type {typeof(T).Name} is not supported.");
    //    }
    //    return value;
    //}
}