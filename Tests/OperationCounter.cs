using Benchmarks;
using System.Collections.Frozen;
using System.Collections.Immutable;
using System.Diagnostics;
using Utilities;

public class OperationCounter
{
    //============== Mechanism ==============
    //1. ImmutableSortedDictionary                                 uses IComparable<T>.CompareTo or IComparable.CompareTo for both Initialize and Contains (but probably uses object.GetHashCode and IEquatable<T>.Equals or object.Equals)
    //2. SortedSet/ImmutableSortedSet                              uses IComparable<T>.CompareTo or IComparable.CompareTo for both Initialize and Contains
    //3. FrozenSet/FrozenDictionary                                uses both object.GetHashCode and IEquatable<T>.Equals or object.Equals for both Initialize and Contains
    //4. HashSet/Dictionary/ImmutableHashSet/ImmutableDictionary   uses object.GetHashCode for Initialize and for Contains, First Check object.GetHashCode, if were the same, then IEquatable<T>.Equals or object.Equals
    //5. Array/List/ImmutableArray/ImmutableList                   uses IEquatable<T>.Equals or object.Equals for Contains

    public static void TestContains()
    {
        const int padRight = 36;
        var arr = BenchmarkBase.GetRandomUniqueArray<int>(1_000_000);
        //var itemsToFound = BenchmarkBase.GetExistedItemsToFind(arr);
        //var itemsToFound = new int[] { -11112, 999999, 515151515, -11112, 999999, 515151515, -11112, 999999, 515151515, -11112, 999999, 515151515, 848488484 };
        var itemsToFound = new int[] { 3864, 3864, 3864, 3864, 3864, 3864, 3864, 3864, 3864, 3864, 3864, 3864 };
        //var itemsToFound = new int[] { 2147474915, 2147474915, 2147474915, 2147474915, 2147474915, 2147474915, 2147474915, 2147474915, 2147474915, 2147474915, 2147474915, 2147474915 };
        //itemsToFound.ShouldAllBe(p => arr.Contains(p) == false);
        var items = arr.Select(p => (Test)p).ToArray().Sort();

        {
            var sw = Stopwatch.StartNew();
            var tests = items.ToList();
            foreach (var item in itemsToFound)
            {
                Test.ResetCounters();
                tests.Contains(item);
                Console.WriteLine("List.Contains():".PadRight(padRight) + Test.PrintCounters().PadRight(10) + item);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        {
            var sw = Stopwatch.StartNew();
            var tests = items.ToList();
            foreach (var item in itemsToFound)
            {
                Test.ResetCounters();
                tests.ContainsBinarySearch(item);
                Console.WriteLine("List.ContainsBinarySearch():".PadRight(padRight) + Test.PrintCounters() + item);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        {
            var sw = Stopwatch.StartNew();
            var tests = items.ToImmutableArray();
            foreach (var item in itemsToFound)
            {
                Test.ResetCounters();
                tests.Contains(item);
                Console.WriteLine("ImmutableArray.Contains():".PadRight(padRight) + Test.PrintCounters() + item);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        {
            var sw = Stopwatch.StartNew();
            var tests = items.ToImmutableList();
            foreach (var item in itemsToFound)
            {
                Test.ResetCounters();
                tests.Contains(item);
                Console.WriteLine("ImmutableList.Contains():".PadRight(padRight) + Test.PrintCounters() + item);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        {
            var sw = Stopwatch.StartNew();
            var tests = items.ToSortedSet();
            foreach (var item in itemsToFound)
            {
                Test.ResetCounters();
                tests.Contains(item);
                Console.WriteLine("SortedSet.Contains():".PadRight(padRight) + Test.PrintCounters() + item);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        {
            var sw = Stopwatch.StartNew();
            var tests = items.ToDictionary();
            foreach (var item in itemsToFound)
            {
                Test.ResetCounters();
                tests.ContainsKey(item);
                Console.WriteLine("Dictionary.ContainsKey():".PadRight(padRight) + Test.PrintCounters() + item);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        {
            var sw = Stopwatch.StartNew();
            var tests = items.ToFrozenDictionary();
            foreach (var item in itemsToFound)
            {
                Test.ResetCounters();
                tests.ContainsKey(item);
                Console.WriteLine("FrozenDictionary.ContainsKey():".PadRight(padRight) + Test.PrintCounters() + item);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        {
            var sw = Stopwatch.StartNew();
            var tests = items.ToFrozenSet();
            foreach (var item in itemsToFound)
            {
                Test.ResetCounters();
                tests.Contains(item);
                Console.WriteLine("FrozenSet.Contains():".PadRight(padRight) + Test.PrintCounters() + item);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
        Console.ReadLine();
    }

    public static void TestInitialize()
    {
        const int padRight = 36;
        var arr = BenchmarkBase.GetRandomUniqueArray<int>(1_000_000);
        var items = arr.Select(p => (Test)p).ToArray();

        Console.WriteLine("============================================ Not Sorted ============================================");
        PrintCounters(items);

        Console.WriteLine();
        Console.WriteLine("============================================ Already Sorted ========================================");
        PrintCounters(items.Sort());


        static void PrintCounters(Test[] items)
        {
            Test.ResetCounters();
            items.ToHashSet();
            Console.WriteLine("ToHashSet:".PadRight(padRight) + Test.PrintCounters());

            Test.ResetCounters();
            items.ToDictionary();
            Console.WriteLine("ToDictionary:".PadRight(padRight) + Test.PrintCounters());

            Test.ResetCounters();
            items.ToSortedSet();
            Console.WriteLine("ToSortedSet:".PadRight(padRight) + Test.PrintCounters());

            Test.ResetCounters();
            items.ToSortedDictionary();
            Console.WriteLine("ToSortedDictionary:".PadRight(padRight) + Test.PrintCounters());

            Test.ResetCounters();
            items.ToFrozenDictionary();
            Console.WriteLine("ToFrozenDictionary:".PadRight(padRight) + Test.PrintCounters());

            Test.ResetCounters();
            items.ToFrozenSet();
            Console.WriteLine("ToFrozenSet:".PadRight(padRight) + Test.PrintCounters());
        }
    }
}

public class Test : IEquatable<Test>, IComparable<Test>
{
    public static int GetHashCodeInvokeCounter { get; set; } = 0;
    public static int EqualsInvokeCounter { get; set; } = 0;
    public static int CompareToInvokeCounter { get; set; } = 0;

    public static void ResetCounters()
    {
        GetHashCodeInvokeCounter = 0;
        EqualsInvokeCounter = 0;
        CompareToInvokeCounter = 0;
    }

    public static string PrintCounters()
    {
        return $"GetHashCode: {GetHashCodeInvokeCounter,-10:N0} Equals: {EqualsInvokeCounter,-10:N0} CompareTo: {CompareToInvokeCounter,-10:N0}";
    }

    public int Id { get; set; }

    public override int GetHashCode()
    {
        GetHashCodeInvokeCounter++;

        return Id.GetHashCode();
    }

    public bool Equals(Test other)
    {
        EqualsInvokeCounter++;

        if (other is null)
            return false;

        return Id == other.Id;
    }

    public int CompareTo(Test other)
    {
        CompareToInvokeCounter++;

        if (other is null)
            return 1;

        return Id.CompareTo(other.Id);
    }

    public static implicit operator Test(int value) => new() { Id = value };
}