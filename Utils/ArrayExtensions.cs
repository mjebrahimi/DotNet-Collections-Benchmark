namespace Utilities;

public static class ArrayExtensions
{
    //https://learn.microsoft.com/en-us/dotnet/api/system.array.indexof
    public static int IndexOf<T>(this T[] array, T item)
    {
        return Array.IndexOf(array, item);
    }

    public static int IndexOf<T>(this T[] array, T item, int startIndex)
    {
        return Array.IndexOf(array, item, startIndex);
    }

    public static int IndexOf<T>(this T[] array, T item, int startIndex, int count)
    {
        return Array.IndexOf(array, item, startIndex, count);
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.lastindexof
    public static int LastIndexOf<T>(this T[] array, T item)
    {
        return Array.LastIndexOf(array, item);
    }

    public static int LastIndexOf<T>(this T[] array, T item, int startIndex)
    {
        return Array.LastIndexOf(array, item, startIndex);
    }

    public static int LastIndexOf<T>(this T[] array, T item, int startIndex, int count)
    {
        return Array.LastIndexOf(array, item, startIndex, count);
    }

    public static bool Contains<T>(this T[] array, T item)
    {
        return Array.IndexOf(array, item) >= 0;
    }

    public static bool Contains<T>(this T[] array, T item, int startIndex)
    {
        return Array.IndexOf(array, item, startIndex) >= 0;
    }

    public static bool Contains<T>(this T[] array, T item, int startIndex, int count)
    {
        return Array.IndexOf(array, item, startIndex, count) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this T[] array, T item)
    {
        return Array.BinarySearch(array, item) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this T[] array, T item, int index, int length)
    {
        return Array.BinarySearch(array, index, length, item) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this T[] array, T item, IComparer<T> comparer)
    {
        return Array.BinarySearch(array, item, comparer) >= 0;
    }

    public static bool ContainsBinarySearch<T>(this T[] array, T item, int index, int length, IComparer<T> comparer)
    {
        return Array.BinarySearch(array, index, length, item, comparer) >= 0;
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.binarysearch
    public static int BinarySearch<T>(this T[] array, T item)
    {
        return Array.BinarySearch(array, item);
    }

    public static int BinarySearch<T>(this T[] array, T item, int index, int length)
    {
        return Array.BinarySearch(array, index, length, item);
    }

    public static int BinarySearch<T>(this T[] array, T item, IComparer<T> comparer)
    {
        return Array.BinarySearch(array, item, comparer);
    }

    public static int BinarySearch<T>(this T[] array, T item, int index, int length, IComparer<T> comparer)
    {
        return Array.BinarySearch(array, index, length, item, comparer);
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.exists
    public static bool Exists<T>(this T[] array, Predicate<T> match)
    {
        return Array.Exists(array, match);
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.fill
    public static T[] Fill<T>(this T[] array, T value)
    {
        Array.Fill(array, value);
        return array;
    }

    public static T[] Fill<T>(this T[] array, T value, int startIndex, int count)
    {
        Array.Fill(array, value, startIndex, count);
        return array;
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.find
    public static T? Find<T>(this T[] array, Predicate<T> match)
    {
        return Array.Find(array, match);
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.findlast
    public static T? FindLast<T>(this T[] array, Predicate<T> match)
    {
        return Array.FindLast(array, match);
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.findall
    public static T[] FindAll<T>(this T[] array, Predicate<T> match)
    {
        return Array.FindAll(array, match);
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.findindex
    public static int FindIndex<T>(this T[] array, Predicate<T> match)
    {
        return Array.FindIndex(array, match);
    }

    public static int FindIndex<T>(this T[] array, Predicate<T> match, int startIndex)
    {
        return Array.FindIndex(array, startIndex, match);
    }

    public static int FindIndex<T>(this T[] array, Predicate<T> match, int startIndex, int count)
    {
        return Array.FindIndex(array, startIndex, count, match);
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.findlastindex
    public static int FindLastIndex<T>(this T[] array, Predicate<T> match)
    {
        return Array.FindLastIndex(array, match);
    }

    public static int FindLastIndex<T>(this T[] array, Predicate<T> match, int startIndex)
    {
        return Array.FindLastIndex(array, startIndex, match);
    }

    public static int FindLastIndex<T>(this T[] array, Predicate<T> match, int startIndex, int count)
    {
        return Array.FindLastIndex(array, startIndex, count, match);
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.foreach
    public static T[] ForEach<T>(this T[] array, Action<T> action)
    {
        Array.ForEach(array, action);
        return array;
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.reverse
    public static T[] Reverse<T>(this T[] array)
    {
        Array.Reverse(array);
        return array;
    }

    public static T[] Reverse<T>(this T[] array, int index, int length)
    {
        Array.Reverse(array, index, length);
        return array;
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.sort
    public static T[] Sort<T>(this T[] array)
    {
        Array.Sort(array);
        return array;
    }

    public static T[] Sort<T>(this T[] array, int index, int length)
    {
        Array.Sort(array, index, length);
        return array;
    }

    public static T[] Sort<T>(this T[] array, IComparer<T> comparer)
    {
        Array.Sort(array, comparer);
        return array;
    }

    public static T[] Sort<T>(this T[] array, int index, int length, IComparer<T> comparer)
    {
        Array.Sort(array, index, length, comparer);
        return array;
    }

    //https://learn.microsoft.com/en-us/dotnet/api/system.array.trueforall
    public static bool TrueForAll<T>(this T[] array, Predicate<T> match)
    {
        return Array.TrueForAll(array, match);
    }

    public static bool TryGetValue<T>(this T[] collection, T value, out T? actualValue)
    {
        var index = collection.IndexOf(value);
        if (index >= 0)
        {
            actualValue = collection[index];
            return true;
        }

        actualValue = default;
        return false;
    }

    public static bool TryGetValueBinarySearch<T>(this T[] collection, T value, out T? actualValue)
    {
        var index = collection.BinarySearch(value);
        if (index >= 0)
        {
            actualValue = collection[index];
            return true;
        }

        actualValue = default;
        return false;
    }

    ////This technique is used in Dictionary structures
    //public static bool TryGetValueByRef<T>(this LinkedList<T> collection, T value, out T? actualValue)
    //{
    //    var node = collection.Find(value);
    //    if (node is not null)
    //    {
    //        ref var valueRef = ref node.ValueRef;
    //        if (!Unsafe.IsNullRef(ref valueRef)) //for ref non-readonly
    //        {
    //            actualValue = valueRef;
    //            return true;
    //        }
    //    }

    //    actualValue = default;
    //    return false;
    //}

    //public static bool TryGetValueByRef<T>(this ImmutableArray<T> collection, T value, out T? actualValue)
    //{
    //    var index = collection.IndexOf(value); //.BinarySearch(value);
    //    if (index >= 0)
    //    {
    //        ref readonly var valueRef = ref collection.ItemRef(index); //for ref readonly
    //        if (!Unsafe.IsNullRef(ref Unsafe.AsRef(in valueRef)))
    //        {
    //            actualValue = valueRef;
    //            return true;
    //        }
    //    }

    //    actualValue = default;
    //    return false;
    //}
}